using Xunit;

namespace LeetCodeLab.Verify.Harness;

public class ExecutionGuardTests
{
    [Fact]
    public void Times_out_a_solution_that_never_returns()
    {
        ProblemFailedException failure = Assert.Throws<ProblemFailedException>(() =>
            ExecutionGuard.Run(
                () => Thread.Sleep(TimeSpan.FromSeconds(30)),
                new Budget(TimeoutMs: 200, MaxAllocatedBytes: null),
                "spin"));

        Assert.Contains("did not finish within 200 ms", failure.Message);
    }

    [Fact]
    public void Rejects_a_solution_over_its_allocation_budget()
    {
        ProblemFailedException failure = Assert.Throws<ProblemFailedException>(() =>
            ExecutionGuard.Run(
                () => new byte[8 * 1024 * 1024],
                new Budget(TimeoutMs: 5000, MaxAllocatedBytes: 1024 * 1024),
                "greedy"));

        Assert.Contains("over the", failure.Message);
    }

    [Fact]
    public void Allows_a_solution_inside_both_budgets()
    {
        int result = ExecutionGuard.Run(
            () => 42, new Budget(TimeoutMs: 5000, MaxAllocatedBytes: 1024 * 1024), "cheap");

        Assert.Equal(42, result);
    }

    [Fact]
    public void Surfaces_the_original_exception_rather_than_a_thread_error()
    {
        Assert.Throws<NotImplementedException>(() =>
            ExecutionGuard.Run<object?>(
                () => throw new NotImplementedException(),
                new Budget(TimeoutMs: 5000, MaxAllocatedBytes: null),
                "stub"));
    }
}

public class GeneratorTests
{
    [Fact]
    public void Generated_input_is_stable_across_runs()
    {
        Assert.Equal(Generated.Ints(7, 1000, -50, 50), Generated.Ints(7, 1000, -50, 50));
        Assert.NotEqual(Generated.Ints(7, 1000, -50, 50), Generated.Ints(8, 1000, -50, 50));
    }

    [Fact]
    public void Permutation_contains_every_value_once()
    {
        int[] values = Generated.Permutation(3, 5000);
        Assert.Equal(5000, values.Distinct().Count());
        Assert.Equal(0, values.Min());
        Assert.Equal(4999, values.Max());
    }

    [Fact]
    public void Ints_respect_their_bounds()
    {
        int[] values = Generated.Ints(5, 10_000, -7, 7);
        Assert.InRange(values.Min(), -7, 7);
        Assert.InRange(values.Max(), -7, 7);
    }
}
