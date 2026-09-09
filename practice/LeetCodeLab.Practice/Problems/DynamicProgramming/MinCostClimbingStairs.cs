namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  746. Min Cost Climbing Stairs                                        [Easy]
//  https://leetcode.com/problems/min-cost-climbing-stairs/
// ----------------------------------------------------------------------------
//  cost[i] is what you pay to step off stair i. You may start at stair 0 or
//  stair 1, and from any stair you climb one or two steps. Return the
//  cheapest way to get past the top.
//
//  Examples
//    cost = [10,15,20]  ->  15
//    cost = [1,100,1,1,1,100,1,1,100,1]  ->  6
//    cost = [0,0]  ->  0
//
//  Constraints
//    2 <= cost.Length <= 1000
//    0 <= cost[i] <= 999
//
//  Hints (read only as many as you need)
//    1. Define best[i] as the cheapest way to REACH stair i, having not yet
//       paid for it.
//    2. You arrive at i either from i-1 or from i-2, paying that stair cost
//       on the way.
//    3. best[i] = min(best[i-1] + cost[i-1], best[i-2] + cost[i-2]). The
//       answer is best at the position just past the last stair.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(746)]
public sealed class MinCostClimbingStairs : ProblemTests<MinCostClimbingStairs>
{
    public int Solve(int[] cost)
    {
        throw new NotImplementedException();
    }
}
