namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  739. Daily Temperatures                                            [Medium]
//  https://leetcode.com/problems/daily-temperatures/
// ----------------------------------------------------------------------------
//  For each day, return how many days you must wait for a warmer temperature.
//  If no warmer day ever comes, the answer for that day is 0.
//
//  Examples
//    temperatures = [73,74,75,71,69,72,76,73]  ->  [1,1,4,2,1,1,0,0]
//    temperatures = [30,40,50,60]  ->  [1,1,1,0]
//    temperatures = [30,60,90]  ->  [1,1,0]
//
//  Constraints
//    1 <= temperatures.Length <= 10^5
//    30 <= temperatures[i] <= 100
//
//  Hints (read only as many as you need)
//    1. The naive scan-forward-from-each-day is O(n^2).
//    2. Keep a stack of days still waiting for a warmer one. Their
//       temperatures decrease from bottom to top.
//    3. When today is warmer than the day on top, today resolves it: pop and
//       record the index difference. Repeat until the stack top is warmer.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(739)]
public sealed class DailyTemperatures : ProblemTests<DailyTemperatures>
{
    public int[] Solve(int[] temperatures)
    {
        throw new NotImplementedException();
    }
}
