using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using LeetCodeLab.Core;

namespace LeetCodeLab.Harness;

/// <summary>
/// Turns LeetCode's loosely-typed JSON arguments into real C# arguments, driven entirely
/// by the target method signature. This is the piece that makes the whole thing work:
/// the same [2,7,11,15] becomes int[] or a ListNode depending on what the method asks for.
/// </summary>
public static class ArgumentBinder
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new CharConverter() },
    };

    public static object?[] Bind(ParameterInfo[] parameters, JsonElement args, int? cyclePos)
    {
        if (args.ValueKind != JsonValueKind.Array)
            throw new InvalidOperationException(
                $"'args' must be a JSON array, found {args.ValueKind}.");

        JsonElement[] raw = [.. args.EnumerateArray()];
        if (raw.Length != parameters.Length)
            throw new InvalidOperationException(
                $"Signature takes {parameters.Length} argument(s) " +
                $"({string.Join(", ", parameters.Select(p => $"{Pretty(p.ParameterType)} {p.Name}"))}) " +
                $"but the case supplies {raw.Length}.");

        object?[] bound = new object?[raw.Length];
        bool cycleApplied = false;

        for (int i = 0; i < raw.Length; i++)
        {
            Type target = parameters[i].ParameterType;
            bound[i] = Convert(raw[i], target);

            // The cycle position is a separate LeetCode input; splice it into the first list.
            if (!cycleApplied && cyclePos is int pos && pos >= 0 && target == typeof(ListNode))
            {
                bound[i] = ListNodes.FromArrayWithCycle(raw[i].Deserialize<int[]>(Options)!, pos);
                cycleApplied = true;
            }
        }

        return bound;
    }

    public static object? Convert(JsonElement element, Type target)
    {
        Type underlying = Nullable.GetUnderlyingType(target) ?? target;

        if (element.ValueKind == JsonValueKind.Object && element.TryGetProperty("$gen", out _))
            return Generate(element, underlying);

        if (underlying == typeof(ListNode))
            return element.ValueKind == JsonValueKind.Null
                ? null
                : ListNodes.FromArray(element.Deserialize<int[]>(Options)!);

        if (underlying == typeof(TreeNode))
            return element.ValueKind == JsonValueKind.Null
                ? null
                : TreeNodes.FromLevelOrder(element.Deserialize<int?[]>(Options)!);

        if (underlying == typeof(ListNode[]))
            return element.EnumerateArray()
                .Select(e => ListNodes.FromArray(e.Deserialize<int[]>(Options)!))
                .ToArray();

        try
        {
            return element.Deserialize(underlying, Options);
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException(
                $"Could not bind {element.GetRawText()} to parameter type {Pretty(underlying)}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Expands a {"$gen": ...} placeholder into a large generated input. Only the recipe is
    /// stored in the case file, so a 200k-element array costs one line of JSON.
    /// </summary>
    private static object Generate(JsonElement spec, Type target)
    {
        string kind = spec.GetProperty("$gen").GetString()
            ?? throw new InvalidOperationException("'$gen' must name a generator.");

        uint Seed() => spec.TryGetProperty("seed", out JsonElement s) ? s.GetUInt32() : 1u;
        int Count() => spec.GetProperty("count").GetInt32();
        int Min() => spec.TryGetProperty("min", out JsonElement m) ? m.GetInt32() : 0;
        int Max() => spec.TryGetProperty("max", out JsonElement m) ? m.GetInt32() : int.MaxValue / 2;

        object value = kind switch
        {
            "ints" => Generated.Ints(Seed(), Count(), Min(), Max()),
            "sortedInts" => Generated.SortedInts(Seed(), Count(), Min(), Max()),
            "permutation" => Generated.Permutation(Seed(), Count()),
            "repeatedChar" => Generated.RepeatedChar(Count(),
                spec.GetProperty("char").GetString()![0]),
            "randomString" => Generated.RandomString(Seed(), Count(),
                spec.TryGetProperty("alphabet", out JsonElement a) ? a.GetString()! : "abc"),
            _ => throw new InvalidOperationException($"Unknown generator '{kind}'."),
        };

        if (!target.IsInstanceOfType(value))
            throw new InvalidOperationException(
                $"Generator '{kind}' produces {Pretty(value.GetType())}, " +
                $"which does not fit parameter type {Pretty(target)}.");

        return value;
    }

    private static string Pretty(Type type) =>
        type.IsArray ? Pretty(type.GetElementType()!) + "[]"
        : type.IsGenericType
            ? type.Name[..type.Name.IndexOf('`')] +
              "<" + string.Join(", ", type.GetGenericArguments().Select(Pretty)) + ">"
        : type.Name;

    /// <summary>LeetCode encodes char grids as arrays of one-character strings.</summary>
    private sealed class CharConverter : JsonConverter<char>
    {
        public override char Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            string s = reader.GetString() ?? "";
            if (s.Length != 1)
                throw new JsonException($"Expected a single-character string for char, got \"{s}\".");
            return s[0];
        }

        public override void Write(Utf8JsonWriter writer, char value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString());
    }
}
