namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  70. Climbing Stairs                                                  [Easy]
//  https://leetcode.com/problems/climbing-stairs/
// ----------------------------------------------------------------------------
//  You climb a staircase of n steps, taking either 1 or 2 steps at a time.
//  Return how many distinct ways there are to reach the top.
//
//  Examples
//    n = 2  ->  2
//    n = 3  ->  3
//    n = 5  ->  8
//
//  Constraints
//    1 <= n <= 45
//
//  Hints (read only as many as you need)
//    1. The last move onto step n came either from step n-1 or from step n-2.
//    2. So ways(n) = ways(n-1) + ways(n-2). These are the Fibonacci numbers.
//    3. You only ever need the last two values, so two integers suffice; no
//       array required.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(70)]
public sealed class ClimbingStairs : ProblemTests<ClimbingStairs>
{
    public int Solve(int n)
    {
        throw new NotImplementedException();
    }
}
