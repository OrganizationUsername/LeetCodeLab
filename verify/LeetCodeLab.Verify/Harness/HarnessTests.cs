using System.Reflection;
using System.Text.Json;
using Xunit;

namespace LeetCodeLab.Verify.Harness;

/// <summary>Tests for the harness itself, separate from the problem case data.</summary>
public class CoverageTests
{
    [Fact]
    public void Every_case_file_has_a_reference_solution()
    {
        IReadOnlyList<string> missing =
            ProblemCoverage.MissingProblemClasses(Assembly.GetExecutingAssembly());

        Assert.True(missing.Count == 0,
            "Case files with no reference solution: " + string.Join(", ", missing));
    }

    [Fact]
    public void Case_files_are_internally_consistent()
    {
        foreach (string file in CaseRepository.AllFiles())
        {
            string name = Path.GetFileNameWithoutExtension(file);
            int id = int.Parse(name.Split('-')[0]);
            ProblemDefinition definition = CaseRepository.Load(id);

            Assert.Equal(id, definition.Id);
            Assert.False(string.IsNullOrWhiteSpace(definition.Title), $"{name} has no title.");
            Assert.Contains(definition.Difficulty, new[] { "Easy", "Medium", "Hard" });
            Assert.StartsWith($"{id:D4}-{definition.Slug}", name);
        }
    }
}

public class ComparerTests
{
    private static object? Json(string raw) => Canonical.Of(JsonDocument.Parse(raw).RootElement);

    [Theory]
    [InlineData("[0,1]", "[1,0]", true)]
    [InlineData("[0,1]", "[0,2]", false)]
    public void Unordered_ignores_position(string expected, string actual, bool passes) =>
        Assert.Equal(passes,
            ResultComparer.Compare(Json(actual), Json(expected), Comparison.Unordered).Passed);

    [Fact]
    public void UnorderedNested_ignores_order_inside_and_out()
    {
        ComparisonResult result = ResultComparer.Compare(
            Json("[[3],[2,1]]"), Json("[[1,2],[3]]"), Comparison.UnorderedNested);
        Assert.True(result.Passed);
    }

    [Fact]
    public void Unordered_keeps_inner_order_significant()
    {
        // Permutations rely on this: [1,2,3] and [3,2,1] are different answers.
        ComparisonResult result = ResultComparer.Compare(
            Json("[[3,2,1]]"), Json("[[1,2,3]]"), Comparison.Unordered);
        Assert.False(result.Passed);
    }

    [Fact]
    public void FloatTolerance_accepts_small_error()
    {
        Assert.True(ResultComparer.Compare(2.000001, 2.0, Comparison.FloatTolerance).Passed);
        Assert.False(ResultComparer.Compare(2.1, 2.0, Comparison.FloatTolerance).Passed);
    }

    [Fact]
    public void Exact_distinguishes_shape()
    {
        Assert.False(ResultComparer.Compare(Json("[1,2]"), Json("[1,2,3]"), Comparison.Exact).Passed);
        Assert.True(ResultComparer.Compare(Json("[[1]]"), Json("[[1]]"), Comparison.Exact).Passed);
    }

    [Fact]
    public void Empty_list_and_tree_canonicalise_to_empty_not_null()
    {
        Assert.Equal(new List<object?>(), Canonical.Of(null, typeof(ListNode)));
        Assert.Equal(new List<object?>(), Canonical.Of(null, typeof(TreeNode)));
        Assert.Null(Canonical.Of(null, typeof(int[])));
    }
}

public class StructureTests
{
    [Fact]
    public void Tree_round_trips_through_leetcode_level_order()
    {
        int?[] input = [3, 9, 20, null, null, 15, 7];
        TreeNode? tree = TreeNodes.FromLevelOrder(input);
        Assert.Equal(input, TreeNodes.ToLevelOrder(tree));
    }

    [Fact]
    public void Tree_omits_children_of_null_slots()
    {
        TreeNode? tree = TreeNodes.FromLevelOrder([1, null, 2]);
        Assert.Null(tree!.left);
        Assert.Equal(2, tree.right!.val);
    }

    [Fact]
    public void List_round_trips()
    {
        Assert.Equal([1, 2, 3], ListNodes.ToArray(ListNodes.FromArray([1, 2, 3])));
        Assert.Empty(ListNodes.ToArray(ListNodes.FromArray([])));
    }

    [Fact]
    public void Cycle_construction_links_tail_to_the_given_index()
    {
        ListNode? head = ListNodes.FromArrayWithCycle([3, 2, 0, -4], 1);
        ListNode tail = head!;
        for (int i = 0; i < 3; i++) tail = tail.next!;
        Assert.Same(head.next, tail.next);
    }

    [Fact]
    public void Materialising_a_cyclic_list_throws_rather_than_hanging()
    {
        ListNode? head = ListNodes.FromArrayWithCycle([1, 2, 3], 0);
        Assert.Throws<InvalidOperationException>(() => ListNodes.ToArray(head, guard: 50));
    }
}
