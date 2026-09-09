namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  621. Task Scheduler                                                [Medium]
//  https://leetcode.com/problems/task-scheduler/
// ----------------------------------------------------------------------------
//  Each task takes one interval, and two runs of the SAME task must be
//  separated by at least n intervals. The CPU may idle. Return the fewest
//  intervals needed to run every task.
//
//  Examples
//    tasks = ["A","A","A","B","B","B"], n = 2  ->  8
//    tasks = ["A","A","A","B","B","B"], n = 0  ->  6
//    tasks = ["A","C","A","B","D","B"], n = 1  ->  6
//
//  Constraints
//    1 <= tasks.Length <= 10^4
//    tasks are uppercase letters A-Z
//    0 <= n <= 100
//    tasks may run in any order
//
//  Hints (read only as many as you need)
//    1. Only the counts matter, not the order the tasks arrive in. The task
//       appearing most often is what forces the idling.
//    2. Picture the most frequent task laid out first, splitting the timeline
//       into (maxCount - 1) blocks each of width n+1. Every other task drops
//       into the gaps.
//    3. That gives (maxCount - 1) * (n + 1) + (how many tasks tie for most
//       frequent). When there are so many distinct tasks that the gaps all
//       fill up, no idling happens at all and the answer is simply
//       tasks.Length - so take the larger of the two.
//
//  Aim for O(tasks) time, O(1) space
// ============================================================================
[Problem(621)]
public sealed class TaskScheduler : ProblemTests<TaskScheduler>
{
    public int Solve(char[] tasks, int n)
    {
        throw new NotImplementedException();
    }
}
