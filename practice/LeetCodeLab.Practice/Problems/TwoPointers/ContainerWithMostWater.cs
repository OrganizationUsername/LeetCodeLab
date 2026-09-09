namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  11. Container With Most Water                                      [Medium]
//  https://leetcode.com/problems/container-with-most-water/
// ----------------------------------------------------------------------------
//  Each height[i] is a vertical line at position i. Pick two lines so that
//  the water held between them is maximal, and return that area. Area is the
//  horizontal distance times the shorter of the two lines.
//
//  Examples
//    height = [1,8,6,2,5,4,8,3,7]  ->  49
//    height = [1,1]  ->  1
//
//  Constraints
//    2 <= height.Length <= 10^5
//    0 <= height[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. Start with the widest possible pair: one pointer at each end.
//    2. Moving either pointer inward always loses width, so it is only worth
//       it if height might increase.
//    3. The shorter line is the one capping the area, so move that one.
//       Keeping it can never help.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(11)]
public sealed class ContainerWithMostWater : ProblemTests<ContainerWithMostWater>
{
    public int Solve(int[] height)
    {
        throw new NotImplementedException();
    }
}
