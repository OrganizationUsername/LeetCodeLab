using System.Reflection;
using System.Text.Json;

namespace LeetCodeLab.Harness;

/// <summary>
/// Drives design problems (LRU Cache, Min Stack, Trie...). LeetCode expresses these as a
/// constructor name followed by method names, with a parallel array of argument lists.
/// </summary>
public static class DesignRunner
{
    public static void Run(Type targetType, ProblemCase testCase)
    {
        string[] ops = testCase.Ops
            ?? throw new InvalidOperationException("Design cases must supply 'ops'.");

        JsonElement[] argSets = [.. testCase.Args.EnumerateArray()];
        if (argSets.Length != ops.Length)
            throw new InvalidOperationException(
                $"'ops' has {ops.Length} entries but 'args' has {argSets.Length}.");

        object?[] expected = Canonical.Of(testCase.Expected) is List<object?> list
            ? [.. list]
            : throw new InvalidOperationException("Design cases must supply an 'expected' array.");

        if (expected.Length != ops.Length)
            throw new InvalidOperationException(
                $"'ops' has {ops.Length} entries but 'expected' has {expected.Length}.");

        object instance = Construct(targetType, argSets[0]);

        for (int i = 1; i < ops.Length; i++)
        {
            MethodInfo method = ResolveOperation(targetType, ops[i], argSets[i].GetArrayLength());
            object?[] args = ArgumentBinder.Bind(method.GetParameters(), argSets[i], cyclePos: null);

            object? returned;
            try
            {
                returned = method.Invoke(instance, args);
            }
            catch (TargetInvocationException ex) when (ex.InnerException is not null)
            {
                throw ex.InnerException;
            }

            object? actual = method.ReturnType == typeof(void)
                ? null
                : Canonical.Of(returned, method.ReturnType);
            ComparisonResult result = ResultComparer.Compare(actual, expected[i], Comparison.Exact);

            if (!result.Passed)
                throw new ProblemFailedException(
                    $"operation {i} ({ops[i]}{argSets[i].GetRawText()}) {result.Reason}" +
                    $"{Environment.NewLine}  sequence: {string.Join(", ", ops)}" +
                    $"{Environment.NewLine}  inputs:   {testCase.Args.GetRawText()}");
        }
    }

    private static object Construct(Type targetType, JsonElement ctorArgs)
    {
        int arity = ctorArgs.GetArrayLength();
        ConstructorInfo constructor = targetType.GetConstructors()
                .FirstOrDefault(c => c.GetParameters().Length == arity)
            ?? throw new InvalidOperationException(
                $"'{targetType.Name}' has no constructor taking {arity} argument(s).");

        object?[] args = ArgumentBinder.Bind(constructor.GetParameters(), ctorArgs, cyclePos: null);

        try
        {
            return constructor.Invoke(args);
        }
        catch (TargetInvocationException ex) when (ex.InnerException is not null)
        {
            throw ex.InnerException;
        }
    }

    /// <summary>LeetCode's op names are camelCase; C# methods are PascalCase.</summary>
    private static MethodInfo ResolveOperation(Type targetType, string name, int arity)
    {
        MethodInfo[] candidates = [.. targetType
            .GetMethods(BindingFlags.Public | BindingFlags.Instance)
            .Where(m => !m.IsSpecialName
                && m.GetParameters().Length == arity
                && string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase))];

        return candidates.Length switch
        {
            1 => candidates[0],
            0 => throw new InvalidOperationException(
                $"'{targetType.Name}' has no public method '{name}' taking {arity} argument(s)."),
            _ => throw new InvalidOperationException(
                $"'{targetType.Name}.{name}' is ambiguous across {candidates.Length} overloads."),
        };
    }
}
