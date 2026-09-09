using System.Text;
using System.Text.Json;
using LeetCodeLab.Harness;

namespace LeetCodeLab.Scaffold;

/// <summary>
/// Renders practice stubs from the case files, so the problem description lives in one
/// place. Existing stubs are never touched unless --force is passed, because that is
/// where your solutions are.
/// </summary>
public static class Program
{
    private const int Width = 76;

    private static readonly JsonSerializerOptions Json = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };

    public static int Main(string[] args)
    {
        bool force = args.Contains("--force");
        string root = FindRepoRoot()
            ?? throw new DirectoryNotFoundException("Could not locate the repo root (no data/ folder found).");

        string problemsDir = Path.Combine(root, "practice", "LeetCodeLab.Practice", "Problems");
        int written = 0, skipped = 0, incomplete = 0;

        foreach (string file in Directory.GetFiles(Path.Combine(root, "data"), "*.json").OrderBy(f => f))
        {
            ProblemDefinition definition =
                JsonSerializer.Deserialize<ProblemDefinition>(File.ReadAllText(file), Json)!;

            if (string.IsNullOrWhiteSpace(definition.Folder)
                || string.IsNullOrWhiteSpace(definition.ClassName)
                || (definition.Design is null && string.IsNullOrWhiteSpace(definition.Signature)))
            {
                Console.WriteLine($"  incomplete metadata: {Path.GetFileName(file)}");
                incomplete++;
                continue;
            }

            string directory = Path.Combine(problemsDir, definition.Folder);
            string target = Path.Combine(directory, definition.ClassName + ".cs");

            if (File.Exists(target) && !force) { skipped++; continue; }

            Directory.CreateDirectory(directory);
            File.WriteAllText(target, Render(definition));
            written++;
        }

        Console.WriteLine($"wrote {written}, left {skipped} existing stub(s) alone, {incomplete} incomplete.");
        return incomplete > 0 ? 1 : 0;
    }

    private static string Render(ProblemDefinition d)
    {
        StringBuilder sb = new();
        if (d.Comparison == Comparison.AnyValid) sb.AppendLine("using System.Text.Json;").AppendLine();
        sb.Append("namespace LeetCodeLab.Practice.Problems.").Append(d.Folder).AppendLine(";").AppendLine();

        string rule = new('=', Width);
        sb.Append("// ").AppendLine(rule);

        string heading = $"{d.Id}. {d.Title}";
        string badge = $"[{d.Difficulty}]";
        int pad = Math.Max(1, Width - heading.Length - badge.Length - 1);
        sb.Append("//  ").Append(heading).Append(new string(' ', pad)).AppendLine(badge);
        if (!string.IsNullOrWhiteSpace(d.Url)) sb.Append("//  ").AppendLine(d.Url);
        sb.Append("// ").AppendLine(new string('-', Width));

        foreach (string line in Wrap(d.Statement)) sb.Append("//  ").AppendLine(line);

        string[] examples = [.. Examples(d)];
        if (examples.Length > 0)
        {
            sb.AppendLine("//");
            sb.AppendLine("//  Examples");
            // A stray newline here would break out of the comment block, so flatten hard.
            foreach (string example in examples)
                sb.Append("//    ").AppendLine(example.Replace("\r", "").Replace("\n", " "));
        }

        if (d.Constraints.Length > 0)
        {
            sb.AppendLine("//");
            sb.AppendLine("//  Constraints");
            foreach (string constraint in d.Constraints) sb.Append("//    ").AppendLine(constraint);
        }

        if (d.Hints.Length > 0)
        {
            sb.AppendLine("//");
            sb.AppendLine("//  Hints (read only as many as you need)");
            for (int i = 0; i < d.Hints.Length; i++)
            {
                string[] wrapped = [.. Wrap(d.Hints[i], Width - 7)];
                sb.Append("//    ").Append(i + 1).Append(". ").AppendLine(wrapped[0]);
                foreach (string line in wrapped.Skip(1)) sb.Append("//       ").AppendLine(line);
            }
        }

        if (!string.IsNullOrWhiteSpace(d.Complexity))
        {
            sb.AppendLine("//");
            sb.Append("//  Aim for ").AppendLine(d.Complexity);
        }

        sb.Append("// ").AppendLine(rule);

        if (d.Design is DesignShape design)
        {
            sb.Append("[Problem(").Append(d.Id).Append(", Target = typeof(").Append(design.Type).AppendLine("))]");
            sb.Append("public sealed class ").Append(d.ClassName)
              .Append(" : ProblemTests<").Append(d.ClassName).AppendLine(">;").AppendLine();

            sb.Append("public class ").AppendLine(design.Type);
            sb.AppendLine("{");
            for (int i = 0; i < design.Members.Length; i++)
            {
                if (i > 0) sb.AppendLine();
                sb.Append("    public ").AppendLine(design.Members[i]);
                sb.AppendLine("    {");
                sb.AppendLine("        throw new NotImplementedException();");
                sb.AppendLine("    }");
            }
            sb.AppendLine("}");
        }
        else
        {
            sb.Append("[Problem(").Append(d.Id).AppendLine(")]");
            sb.Append("public sealed class ").Append(d.ClassName)
              .Append(" : ProblemTests<").Append(d.ClassName).AppendLine(">");
            sb.AppendLine("{");
            sb.Append("    public ").AppendLine(d.Signature);
            sb.AppendLine("    {");
            sb.AppendLine("        throw new NotImplementedException();");
            sb.AppendLine("    }");

            foreach (string member in d.ExtraMembers)
            {
                sb.AppendLine();
                foreach (string line in member.Replace("\r\n", "\n").Split('\n'))
                    sb.AppendLine(line.Length == 0 ? "" : "    " + line);
            }

            sb.AppendLine("}");
        }

        return sb.ToString();
    }

    /// <summary>Worked examples come from the case data, so they can never drift from it.</summary>
    private static IEnumerable<string> Examples(ProblemDefinition d)
    {
        string[] names = ParameterNames(d.Signature);

        foreach (ProblemCase c in d.Cases.Take(3))
        {
            string raw = c.Args.GetRawText();
            if (raw.Contains("$gen")) continue;

            if (d.Design is not null)
            {
                yield return string.Join(", ", c.Ops ?? []);
                yield return "  with " + Compact(raw, 64);
                yield return "  ->   " + Compact(c.Expected.GetRawText(), 64);
                continue;
            }

            JsonElement[] args = [.. c.Args.EnumerateArray()];
            string inputs = string.Join(", ", args.Select((a, i) =>
                (i < names.Length ? names[i] + " = " : "") + Compact(a.GetRawText())));

            string outcome = d.Comparison switch
            {
                Comparison.MutatedArg =>
                    $"{(names.Length > 0 ? names[0] : "arg0")} becomes {Compact(c.Expected.GetRawText())}",
                Comparison.InPlacePrefix =>
                    $"{Compact(c.Expected.GetRawText())}, with the first "
                    + $"{Compact(c.Expected.GetRawText())} entries "
                    + $"{Compact(c.ExpectedArray?.GetRawText() ?? "[]")}",
                Comparison.AnyValid =>
                    $"{Compact(c.Expected.GetRawText())}  (other answers may also be accepted)",
                _ => Compact(c.Expected.GetRawText()),
            };

            yield return $"{inputs}  ->  {outcome}";
        }
    }

    private static string[] ParameterNames(string signature)
    {
        int open = signature.IndexOf('(');
        int close = signature.LastIndexOf(')');
        if (open < 0 || close <= open) return [];

        string inside = signature[(open + 1)..close].Trim();
        if (inside.Length == 0) return [];

        return [.. inside.Split(',').Select(part => part.Trim().Split(' ').Last())];
    }

    private static string Compact(string json, int max = 46)
    {
        string flat = json.Replace("\r", "").Replace("\n", "").Replace(" ", "");
        return flat.Length <= max ? flat : flat[..(max - 3)] + "...";
    }

    private static IEnumerable<string> Wrap(string text, int width = Width - 2)
    {
        foreach (string paragraph in text.Replace("\r\n", "\n").Split('\n'))
        {
            if (paragraph.Trim().Length == 0) { yield return ""; continue; }

            StringBuilder line = new();
            foreach (string word in paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.Length > 0 && line.Length + 1 + word.Length > width)
                {
                    yield return line.ToString();
                    line.Clear();
                }
                if (line.Length > 0) line.Append(' ');
                line.Append(word);
            }
            if (line.Length > 0) yield return line.ToString();
        }
    }

    private static string? FindRepoRoot()
    {
        for (DirectoryInfo? dir = new(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
            if (Directory.Exists(Path.Combine(dir.FullName, "data"))
                && Directory.Exists(Path.Combine(dir.FullName, "practice")))
                return dir.FullName;
        return null;
    }
}
