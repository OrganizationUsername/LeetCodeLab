namespace LeetCodeLab.Harness;

/// <summary>Binds a solution class to its case file in /data (matched by numeric id).</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ProblemAttribute(int id) : Attribute
{
    public int Id { get; } = id;

    /// <summary>
    /// For design problems: the stateful class the operation sequence is driven against.
    /// It lives outside the test class because xUnit must be able to construct the test class itself.
    /// </summary>
    public Type? Target { get; init; }
}

/// <summary>
/// Marks the method under test when a class exposes more than one public method.
/// Not needed for the common single-method case.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class SolutionAttribute : Attribute;
