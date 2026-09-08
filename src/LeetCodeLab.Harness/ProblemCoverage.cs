using System.Reflection;

namespace LeetCodeLab.Harness;

/// <summary>
/// Guards against the silent failure mode of a data-driven suite: a case file that no
/// class claims contributes zero tests, so the suite stays green while coverage drops.
/// </summary>
public static class ProblemCoverage
{
    /// <summary>Case files in /data with no matching [Problem] class in the assembly.</summary>
    public static IReadOnlyList<string> MissingProblemClasses(Assembly assembly)
    {
        HashSet<int> declared =
        [
            .. assembly.GetTypes()
                .Select(type => type.GetCustomAttribute<ProblemAttribute>())
                .Where(attribute => attribute is not null)
                .Select(attribute => attribute!.Id)
        ];

        List<string> missing = [];
        foreach (string file in CaseRepository.AllFiles())
        {
            string name = Path.GetFileNameWithoutExtension(file);
            if (int.TryParse(name.Split('-')[0], out int id) && !declared.Contains(id))
                missing.Add(name);
        }
        return missing;
    }
}
