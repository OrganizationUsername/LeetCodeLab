using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace LeetCodeLab.Harness;

/// <summary>Time and allocation limits applied to a single case.</summary>
public sealed record Budget(int TimeoutMs, long? MaxAllocatedBytes)
{
    public const int DefaultTimeoutMs = 5000;
}

/// <summary>
/// Runs a solution on a dedicated worker thread so a hang or a runaway allocation fails the
/// test instead of wedging the run.
///
/// A thread that blows its timeout cannot be aborted - .NET removed Thread.Abort and there
/// is no safe replacement - so it is left running as a background thread and dies with the
/// process. That means a genuine infinite loop keeps burning one core for the rest of the
/// run. It is reported correctly, which is what matters; just don't be surprised by the fan.
/// </summary>
public static class ExecutionGuard
{
    // Deep recursion on generated inputs overflows the default 1 MB stack.
    private const int StackBytes = 64 * 1024 * 1024;

    public static T Run<T>(Func<T> body, Budget budget, string what)
    {
        T result = default!;
        ExceptionDispatchInfo? failure = null;
        long allocated = 0;

        Thread worker = new(() =>
        {
            long before = GC.GetAllocatedBytesForCurrentThread();
            try
            {
                result = body();
            }
            catch (Exception ex)
            {
                failure = ExceptionDispatchInfo.Capture(ex);
            }
            finally
            {
                allocated = GC.GetAllocatedBytesForCurrentThread() - before;
            }
        }, StackBytes)
        {
            IsBackground = true,
            Name = "leetcodelab-solution",
        };

        Stopwatch clock = Stopwatch.StartNew();
        worker.Start();
        bool finished = worker.Join(budget.TimeoutMs);
        clock.Stop();

        if (!finished)
            throw new ProblemFailedException(
                $"{what} did not finish within {budget.TimeoutMs} ms. " +
                "That is either an infinite loop or a solution whose complexity is too high " +
                "for this input size.");

        failure?.Throw();

        if (budget.MaxAllocatedBytes is long cap && allocated > cap)
            throw new ProblemFailedException(
                $"{what} allocated {allocated:N0} bytes, over the {cap:N0} byte budget " +
                $"(finished in {clock.ElapsedMilliseconds} ms).");

        return result;
    }

    public static void Run(Action body, Budget budget, string what) =>
        Run<object?>(() => { body(); return null; }, budget, what);
}
