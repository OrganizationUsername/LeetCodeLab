namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  198. House Robber                                                  [Medium]
//  https://leetcode.com/problems/house-robber/
// ----------------------------------------------------------------------------
//  Each value is the money in a house along a street. You cannot rob two
//  adjacent houses. Return the maximum you can take.
//
//  Examples
//    nums = [1,2,3,1]  ->  4
//    nums = [2,7,9,3,1]  ->  12
//    nums = [2,1,1,2]  ->  4
//
//  Constraints
//    1 <= nums.Length <= 100
//    0 <= nums[i] <= 400
//
//  Hints (read only as many as you need)
//    1. At each house you either take it, which forces you to skip the
//       previous one, or you skip it.
//    2. best(i) = max(best(i-1), best(i-2) + nums[i]).
//    3. Only two running values are needed, so this is O(1) space.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(198)]
public sealed class HouseRobber : ProblemTests<HouseRobber>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
