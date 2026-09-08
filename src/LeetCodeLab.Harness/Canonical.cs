using System.Collections;
using System.Text.Json;
using LeetCodeLab.Core;

namespace LeetCodeLab.Harness;

/// <summary>
/// Reduces both actual results and expected JSON to one shape - null, bool, string,
/// double, or List of object - so a single comparer handles every problem.
/// </summary>
public static class Canonical
{
    /// <summary>
    /// Type-aware overload. A null ListNode or TreeNode is an empty structure, and LeetCode
    /// writes those as [] rather than null - so the declared type decides which null we have.
    /// </summary>
    public static object? Of(object? value, Type? declaredType)
    {
        if (value is null && declaredType is not null)
        {
            Type type = Nullable.GetUnderlyingType(declaredType) ?? declaredType;
            if (type == typeof(ListNode) || type == typeof(TreeNode)) return new List<object?>();
        }
        return Of(value);
    }

    public static object? Of(object? value) => value switch
    {
        null => null,
        bool b => b,
        string s => s,
        char c => c.ToString(),
        sbyte or byte or short or ushort or int or uint or long or ulong or float or double or decimal
            => System.Convert.ToDouble(value),
        ListNode node => ListNodes.ToArray(node).Select(v => (object?)(double)v).ToList(),
        TreeNode tree => TreeNodes.ToLevelOrder(tree)
            .Select(v => v is null ? null : (object?)(double)v.Value).ToList(),
        IEnumerable seq => seq.Cast<object?>().Select(Of).ToList(),
        _ => throw new NotSupportedException(
            $"No canonical form for result type '{value.GetType()}'. Add a case to Canonical.Of."),
    };

    public static object? Of(JsonElement element) => element.ValueKind switch
    {
        JsonValueKind.Null or JsonValueKind.Undefined => null,
        JsonValueKind.True => true,
        JsonValueKind.False => false,
        JsonValueKind.String => element.GetString(),
        JsonValueKind.Number => element.GetDouble(),
        JsonValueKind.Array => element.EnumerateArray().Select(Of).ToList(),
        _ => throw new NotSupportedException(
            $"Expected values may not be JSON objects (found {element.ValueKind})."),
    };

    /// <summary>Stable ordering key, so unordered comparisons can sort before comparing.</summary>
    public static string Key(object? value) => value switch
    {
        null => " null",
        bool b => "b" + b,
        string s => "s" + s,
        double d => "n" + d.ToString("R"),
        List<object?> list => "[" + string.Join(",", list.Select(Key)) + "]",
        _ => "?" + value,
    };

    public static string Render(object? value) => value switch
    {
        null => "null",
        bool b => b ? "true" : "false",
        string s => "\"" + s + "\"",
        double d => d == Math.Floor(d) && Math.Abs(d) < 1e15
            ? ((long)d).ToString()
            : d.ToString("0.#####"),
        List<object?> list => "[" + string.Join(",", list.Select(Render)) + "]",
        _ => value.ToString() ?? "null",
    };
}
