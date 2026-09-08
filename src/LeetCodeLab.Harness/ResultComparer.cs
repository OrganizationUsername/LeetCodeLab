namespace LeetCodeLab.Harness;

public readonly record struct ComparisonResult(bool Passed, string? Reason)
{
    public static readonly ComparisonResult Pass = new(true, null);
    public static ComparisonResult Fail(string reason) => new(false, reason);
}

/// <summary>Judges a canonical actual value against a canonical expected value.</summary>
public static class ResultComparer
{
    public const double Tolerance = 1e-5;

    public static ComparisonResult Compare(object? actual, object? expected, Comparison mode)
    {
        bool ok = mode switch
        {
            Comparison.Unordered => UnorderedEqual(actual, expected, nested: false),
            Comparison.UnorderedNested => UnorderedEqual(actual, expected, nested: true),
            Comparison.FloatTolerance => DeepEqual(actual, expected, Tolerance),
            _ => DeepEqual(actual, expected, 0d),
        };

        return ok
            ? ComparisonResult.Pass
            : ComparisonResult.Fail(
                $"expected {Canonical.Render(expected)} but got {Canonical.Render(actual)}");
    }

    private static bool DeepEqual(object? a, object? b, double tolerance)
    {
        if (a is null || b is null) return a is null && b is null;

        if (a is double da && b is double db)
            return tolerance > 0 ? Math.Abs(da - db) <= tolerance : da.Equals(db);

        if (a is List<object?> la && b is List<object?> lb)
            return la.Count == lb.Count
                && la.Zip(lb).All(pair => DeepEqual(pair.First, pair.Second, tolerance));

        return a.Equals(b);
    }

    /// <summary>
    /// Order-insensitive comparison. When nested, inner sequences are also sorted, so
    /// [[1,2],[3]] matches [[3],[2,1]] - the shape LeetCode uses for 3Sum, Subsets, and friends.
    /// </summary>
    private static bool UnorderedEqual(object? a, object? b, bool nested)
    {
        if (a is not List<object?> la || b is not List<object?> lb) return DeepEqual(a, b, 0d);
        if (la.Count != lb.Count) return false;

        static List<object?> Normalize(List<object?> list, bool nested)
        {
            IEnumerable<object?> items = nested
                ? list.Select(item => item is List<object?> inner
                    ? inner.OrderBy(Canonical.Key, StringComparer.Ordinal).ToList()
                    : item)
                : list;
            return [.. items.OrderBy(Canonical.Key, StringComparer.Ordinal)];
        }

        return DeepEqual(Normalize(la, nested), Normalize(lb, nested), 0d);
    }
}
