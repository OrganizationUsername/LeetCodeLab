using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;

namespace LeetCodeLab.Harness;

/// <summary>Loads and caches case files copied into the test assembly's output/data folder.</summary>
public static class CaseRepository
{
    private static readonly ConcurrentDictionary<int, ProblemDefinition> Cache = new();

    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };

    public static string DataDirectory { get; } =
        Path.Combine(AppContext.BaseDirectory, "data");

    public static ProblemDefinition Load(int id) => Cache.GetOrAdd(id, static key =>
    {
        if (!Directory.Exists(DataDirectory))
            throw new DirectoryNotFoundException(
                $"Case data folder not found at '{DataDirectory}'. " +
                "Check that the test project sets <IsProblemTestProject>true</IsProblemTestProject>.");

        string[] matches = Directory
            .GetFiles(DataDirectory, $"{key:D4}-*.json")
            .Concat(Directory.GetFiles(DataDirectory, $"{key:D4}.json"))
            .Distinct()
            .ToArray();

        if (matches.Length == 0)
            throw new FileNotFoundException($"No case file for problem {key} in '{DataDirectory}'.");
        if (matches.Length > 1)
            throw new InvalidOperationException(
                $"Problem {key} matches several case files: {string.Join(", ", matches.Select(Path.GetFileName))}");

        ProblemDefinition def = JsonSerializer.Deserialize<ProblemDefinition>(
            File.ReadAllText(matches[0]), Options)
            ?? throw new InvalidOperationException($"Case file '{matches[0]}' deserialized to null.");

        if (def.Cases.Count == 0)
            throw new InvalidOperationException($"Case file '{matches[0]}' contains no cases.");

        return def;
    });

    /// <summary>Resolves the [Problem] id for a solution type.</summary>
    public static int IdOf(Type problemType) =>
        problemType.GetCustomAttribute<ProblemAttribute>()?.Id
        ?? throw new InvalidOperationException(
            $"Type '{problemType.Name}' is missing [Problem(id)].");

    /// <summary>Every case file present on disk - used by the data-integrity test.</summary>
    public static IEnumerable<string> AllFiles() =>
        Directory.Exists(DataDirectory)
            ? Directory.GetFiles(DataDirectory, "*.json").OrderBy(f => f)
            : [];
}
