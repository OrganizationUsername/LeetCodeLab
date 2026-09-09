using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace LeetCodeLab.Harness;

/// <summary>Thrown when a case fails. xUnit surfaces the message directly in Test Explorer.</summary>
public sealed class ProblemFailedException(string message) : Exception(message);

public static class ProblemRunner
{
    public static void Run(Type problemType, object? instance, int caseIndex)
    {
        ProblemAttribute attribute = problemType.GetCustomAttribute<ProblemAttribute>()
            ?? throw new InvalidOperationException($"'{problemType.Name}' is missing [Problem(id)].");

        ProblemDefinition definition = CaseRepository.Load(attribute.Id);
        ProblemCase testCase = definition.Cases[caseIndex];

        Budget budget = new(
            testCase.TimeoutMs ?? definition.TimeoutMs,
            testCase.MaxAllocatedBytes ?? definition.MaxAllocatedBytes);

        if (definition.Comparison == Comparison.Design)
        {
            ExecutionGuard.Run(
                () => DesignRunner.Run(attribute.Target ?? problemType, testCase),
                budget, "The operation sequence");
            return;
        }

        MethodInfo method = ResolveMethod(problemType);

        // Binding happens outside the budget: materialising a generated 200k-element
        // input is the harness's cost, not the solution's.
        object?[] args = ArgumentBinder.Bind(method.GetParameters(), testCase.Args, testCase.CyclePos);

        object? returned = ExecutionGuard.Run(() =>
        {
            try
            {
                return method.Invoke(instance, args);
            }
            catch (TargetInvocationException ex) when (ex.InnerException is not null)
            {
                // Unwrap so the stack trace points at the solution, not at reflection.
                throw ex.InnerException;
            }
        }, budget, $"{problemType.Name}.{method.Name}");

        Judge(problemType, definition, testCase, method, args, returned);
    }

    private static void Judge(
        Type problemType,
        ProblemDefinition definition,
        ProblemCase testCase,
        MethodInfo method,
        object?[] args,
        object? returned)
    {
        object? expected = Canonical.Of(testCase.Expected);

        switch (definition.Comparison)
        {
            case Comparison.MutatedArg:
            {
                object? mutated = Canonical.Of(args[0], method.GetParameters()[0].ParameterType);
                Assert(ResultComparer.Compare(mutated, expected, Comparison.Exact), testCase, args,
                    "after the call, argument 0");
                return;
            }

            case Comparison.InPlacePrefix:
            {
                object? k = Canonical.Of(returned);
                Assert(ResultComparer.Compare(k, expected, Comparison.Exact), testCase, args,
                    "returned length");

                if (testCase.ExpectedArray is not JsonElement expectedPrefix)
                    throw new InvalidOperationException(
                        "InPlacePrefix cases must supply 'expectedArray'.");

                if (Canonical.Of(args[0]) is not List<object?> mutated)
                    throw new InvalidOperationException("InPlacePrefix requires a sequence as argument 0.");

                int count = (int)(double)k!;
                if (count > mutated.Count)
                    Fail(testCase, args, $"returned {count} but argument 0 only has {mutated.Count} elements");

                Assert(
                    ResultComparer.Compare(
                        mutated.Take(count).ToList(),
                        Canonical.Of(expectedPrefix),
                        definition.PrefixOrdered ? Comparison.Exact : Comparison.Unordered),
                    testCase, args, $"first {count} element(s) of argument 0");
                return;
            }

            case Comparison.AnyValid:
            {
                MethodInfo validator = problemType.GetMethod("Validate",
                        BindingFlags.Public | BindingFlags.Static)
                    ?? throw new InvalidOperationException(
                        $"'{problemType.Name}' uses AnyValid and must declare 'public static bool " +
                        "Validate(object?[] args, object? actual, JsonElement expected)'.");

                // The validator sees one known-good answer, so it can check length or cost
                // without re-deriving the answer and leaking the solution into the stub.
                bool valid = (bool)validator.Invoke(null, [args, returned, testCase.Expected])!;
                if (!valid)
                    Fail(testCase, args, $"{Canonical.Render(Canonical.Of(returned))} is not a valid answer");
                return;
            }

            default:
                Assert(
                    ResultComparer.Compare(
                        Canonical.Of(returned, method.ReturnType), expected, definition.Comparison),
                    testCase, args, "result");
                return;
        }
    }

    private static void Assert(ComparisonResult result, ProblemCase testCase, object?[] args, string what)
    {
        if (!result.Passed) Fail(testCase, args, $"{what}: {result.Reason}");
    }

    private static void Fail(ProblemCase testCase, object?[] args, string detail) =>
        throw new ProblemFailedException(
            $"{detail}{Environment.NewLine}  input: {testCase.Args.GetRawText()}");

    /// <summary>
    /// Finds the solution method: the [Solution]-marked one, or the single public method
    /// declared directly on the class (base-class plumbing is excluded by DeclaredOnly).
    /// </summary>
    public static MethodInfo ResolveMethod(Type problemType)
    {
        MethodInfo[] declared = [.. problemType
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName
                && m.GetCustomAttribute<CompilerGeneratedAttribute>() is null)];

        MethodInfo[] marked = [.. declared.Where(m => m.GetCustomAttribute<SolutionAttribute>() is not null)];
        if (marked.Length == 1) return marked[0];
        if (marked.Length > 1)
            throw new InvalidOperationException($"'{problemType.Name}' has more than one [Solution] method.");

        return declared.Length switch
        {
            1 => declared[0],
            0 => throw new InvalidOperationException(
                $"'{problemType.Name}' declares no public method to test."),
            _ => throw new InvalidOperationException(
                $"'{problemType.Name}' declares {declared.Length} public methods " +
                $"({string.Join(", ", declared.Select(m => m.Name))}). Mark one with [Solution]."),
        };
    }
}
