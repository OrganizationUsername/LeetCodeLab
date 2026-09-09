namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  42. Trapping Rain Water                                              [Hard]
//  https://leetcode.com/problems/trapping-rain-water/
// ----------------------------------------------------------------------------
//  The array is an elevation map of unit-width bars. Return how many units of
//  water are trapped after rain.
//
//  Examples
//    height = [0,1,0,2,1,0,1,3,2,1,2,1]  ->  6
//    height = [4,2,0,3,2,5]  ->  9
//
//  Constraints
//    1 <= height.Length <= 2*10^4
//    0 <= height[i] <= 10^5
//
//  Hints (read only as many as you need)
//    1. Think per column, not per pool. Water above column i is min(tallest
//       to its left, tallest to its right) - height[i].
//    2. Precomputing both maxima into two arrays gives an easy O(n) time,
//       O(n) space solution.
//    3. For O(1) space, walk two pointers inward and always advance the side
//       with the smaller running maximum: that side answer is already
//       determined.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(42)]
public sealed class TrappingRainWater : ProblemTests<TrappingRainWater>
{
    public int Solve(int[] height)
    {
        throw new NotImplementedException();
    }
}
