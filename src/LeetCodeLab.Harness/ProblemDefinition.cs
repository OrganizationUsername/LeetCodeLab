using System.Text.Json;
using System.Text.Json.Serialization;

namespace LeetCodeLab.Harness;

/// <summary>How a returned value is judged. LeetCode is not uniformly "assert equal".</summary>
public enum Comparison
{
    /// <summary>Deep structural equality.</summary>
    Exact,
    /// <summary>A flat sequence where element order is not significant.</summary>
    Unordered,
    /// <summary>A sequence of sequences where neither inner nor outer order is significant.</summary>
    UnorderedNested,
    /// <summary>Numeric result within 1e-5, matching LeetCode's usual tolerance.</summary>
    FloatTolerance,
    /// <summary>Returns k; the first k elements of the mutated first argument must match.</summary>
    InPlacePrefix,
    /// <summary>Result is the mutation of the first argument, not the return value.</summary>
    MutatedArg,
    /// <summary>Multiple answers accepted; the problem class supplies a static Validate method.</summary>
    AnyValid,
    /// <summary>Constructor + method-call sequence against a stateful object.</summary>
    Design,
}

public sealed class ProblemDefinition
{
    public int Id { get; init; }
    public string Slug { get; init; } = "";
    public string Title { get; init; } = "";
    public string Difficulty { get; init; } = "Medium";
    public string[] Topics { get; init; } = [];
    public string Url { get; init; } = "";

    [JsonConverter(typeof(JsonStringEnumConverter<Comparison>))]
    public Comparison Comparison { get; init; } = Comparison.Exact;

    /// <summary>Wall-clock limit per case, overridable on the case itself.</summary>
    public int TimeoutMs { get; init; } = Budget.DefaultTimeoutMs;

    /// <summary>Optional cap on bytes allocated by the solution. Null means unlimited.</summary>
    public long? MaxAllocatedBytes { get; init; }

    public List<ProblemCase> Cases { get; init; } = [];
}

public sealed class ProblemCase
{
    /// <summary>Positional arguments, bound to the solution signature by parameter type.</summary>
    public JsonElement Args { get; init; }

    /// <summary>Expected return value (or, for MutatedArg, the expected final state of arg 0).</summary>
    public JsonElement Expected { get; init; }

    /// <summary>For InPlacePrefix: the expected prefix contents of the mutated array.</summary>
    public JsonElement? ExpectedArray { get; init; }

    /// <summary>For Design: the ordered operation names, starting with the constructor.</summary>
    public string[]? Ops { get; init; }

    /// <summary>Links the tail of the first ListNode argument back to this index. -1 or null for no cycle.</summary>
    public int? CyclePos { get; init; }

    /// <summary>Optional human label; falls back to a rendering of the arguments.</summary>
    public string? Name { get; init; }

    /// <summary>Per-case overrides of the problem-level budget.</summary>
    public int? TimeoutMs { get; init; }
    public long? MaxAllocatedBytes { get; init; }
}
