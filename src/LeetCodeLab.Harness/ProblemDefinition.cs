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

    // ---- Teaching material, rendered into the stub by tools/Scaffold ----

    /// <summary>The task, in this repo's own words rather than LeetCode's.</summary>
    public string Statement { get; init; } = "";

    /// <summary>Input bounds, one per line.</summary>
    public string[] Constraints { get; init; } = [];

    /// <summary>Graded nudges, vaguest first. Read as few as you can get away with.</summary>
    public string[] Hints { get; init; } = [];

    /// <summary>The complexity you should be aiming for, e.g. "O(n) time, O(1) space".</summary>
    public string Complexity { get; init; } = "";

    // ---- Scaffolding metadata ----

    /// <summary>Folder under Problems/ and the last segment of the namespace.</summary>
    public string Folder { get; init; } = "";

    /// <summary>Generated class name.</summary>
    public string ClassName { get; init; } = "";

    /// <summary>Signature of the method you implement, e.g. "int[] Solve(int[] nums, int target)".</summary>
    public string Signature { get; init; } = "";

    /// <summary>For design problems: the stateful type and its members.</summary>
    public DesignShape? Design { get; init; }

    /// <summary>
    /// Raw C# appended inside the generated class. Used for the Validate method that
    /// AnyValid problems must supply, which is harness plumbing rather than your solution.
    /// </summary>
    public string[] ExtraMembers { get; init; } = [];

    [JsonConverter(typeof(JsonStringEnumConverter<Comparison>))]
    public Comparison Comparison { get; init; } = Comparison.Exact;

    /// <summary>
    /// For InPlacePrefix: whether the surviving prefix must keep its relative order.
    /// Remove Duplicates says yes; Remove Element accepts any order.
    /// </summary>
    public bool PrefixOrdered { get; init; } = true;

    /// <summary>Wall-clock limit per case, overridable on the case itself.</summary>
    public int TimeoutMs { get; init; } = Budget.DefaultTimeoutMs;

    /// <summary>Optional cap on bytes allocated by the solution. Null means unlimited.</summary>
    public long? MaxAllocatedBytes { get; init; }

    public List<ProblemCase> Cases { get; init; } = [];
}

/// <summary>Shape of a design problem's class, used to scaffold the stub.</summary>
public sealed class DesignShape
{
    /// <summary>Class name, matching the constructor op in the case file.</summary>
    public string Type { get; init; } = "";

    /// <summary>Constructor first, then one entry per method, e.g. "int Get(int key)".</summary>
    public string[] Members { get; init; } = [];
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
