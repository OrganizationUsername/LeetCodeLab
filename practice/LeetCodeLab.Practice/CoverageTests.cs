using System.Reflection;
using Xunit;

namespace LeetCodeLab.Practice;

/// <summary>
/// The one test here that should always be green. If you drop a new case file into /data
/// without writing a matching stub, this is what tells you.
/// </summary>
public class CoverageTests
{
    [Fact]
    public void Every_case_file_has_a_problem_class()
    {
        IReadOnlyList<string> missing =
            ProblemCoverage.MissingProblemClasses(Assembly.GetExecutingAssembly());

        Assert.True(missing.Count == 0,
            "Case files with no problem class: " + string.Join(", ", missing));
    }
}
