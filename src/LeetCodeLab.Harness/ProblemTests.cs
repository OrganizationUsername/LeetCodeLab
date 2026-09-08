using System.Reflection;
using Xunit;
using Xunit.Sdk;
using Xunit.v3;

namespace LeetCodeLab.Harness;

/// <summary>
/// Expands a problem's case file into one Test Explorer row per case, tagged with
/// difficulty and topic so you can filter down to "unsolved Mediums about DP".
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class ProblemDataAttribute : DataAttribute
{
    public override ValueTask<IReadOnlyCollection<ITheoryDataRow>> GetData(
        MethodInfo testMethod, DisposalTracker disposalTracker)
    {
        Type problemType = ResolveProblemType(testMethod);
        ProblemDefinition definition = CaseRepository.Load(CaseRepository.IdOf(problemType));

        Dictionary<string, HashSet<string>> traits = new(StringComparer.OrdinalIgnoreCase)
        {
            ["Difficulty"] = [definition.Difficulty],
            ["Problem"] = [definition.Id.ToString()],
        };
        if (definition.Topics.Length > 0) traits["Topic"] = [.. definition.Topics];

        List<ITheoryDataRow> rows = [];
        for (int i = 0; i < definition.Cases.Count; i++)
        {
            rows.Add(new TheoryDataRow<int>(i)
            {
                TestDisplayName = $"{definition.Id}. {definition.Title} #{i + 1}: {Describe(definition.Cases[i])}",
                Traits = traits,
            });
        }

        return new ValueTask<IReadOnlyCollection<ITheoryDataRow>>(rows);
    }

    public override bool SupportsDiscoveryEnumeration() => true;

    private static string Describe(ProblemCase testCase)
    {
        if (!string.IsNullOrWhiteSpace(testCase.Name)) return testCase.Name!;

        string raw = testCase.Ops is { Length: > 0 }
            ? string.Join(",", testCase.Ops)
            : testCase.Args.GetRawText();

        raw = raw.Replace("\r", "").Replace("\n", "").Replace(" ", "");
        return raw.Length <= 60 ? raw : raw[..57] + "...";
    }

    /// <summary>
    /// Walks up from the test class to find the [Problem]-marked type. Handles both the
    /// class itself carrying the attribute and the ProblemTests&lt;T&gt; generic argument.
    /// </summary>
    private static Type ResolveProblemType(MethodInfo testMethod)
    {
        Type? start = testMethod.ReflectedType ?? testMethod.DeclaringType;

        for (Type? type = start; type is not null; type = type.BaseType)
        {
            if (type.GetCustomAttribute<ProblemAttribute>(inherit: false) is not null) return type;

            if (type.IsGenericType)
            {
                foreach (Type argument in type.GetGenericArguments())
                {
                    if (argument.GetCustomAttribute<ProblemAttribute>(inherit: false) is not null)
                        return argument;
                }
            }
        }

        throw new InvalidOperationException(
            $"Could not find a [Problem]-marked type for '{start?.Name ?? testMethod.Name}'.");
    }
}

/// <summary>
/// Base class for every problem. Inheriting it is what puts the problem in Test Explorer;
/// the derived class supplies the [Problem] id and the method you are implementing.
/// </summary>
public abstract class ProblemTests<TSelf> where TSelf : ProblemTests<TSelf>
{
    [Theory]
    [ProblemData]
    public void Case(int index) => ProblemRunner.Run(typeof(TSelf), this, index);
}
