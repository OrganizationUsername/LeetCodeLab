namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  213. House Robber II                                               [Medium]
//  https://leetcode.com/problems/house-robber-ii/
// ----------------------------------------------------------------------------
//  Same as House Robber, except the houses are arranged in a CIRCLE, so the
//  first and last are adjacent and cannot both be robbed. Return the maximum
//  you can take.
//
//  Examples
//    nums = [2,3,2]  ->  3
//    nums = [1,2,3,1]  ->  4
//    nums = [1,2,3]  ->  3
//
//  Constraints
//    1 <= nums.Length <= 100
//    0 <= nums[i] <= 1000
//
//  Hints (read only as many as you need)
//    1. The circle only adds one constraint: house 0 and house n-1 cannot
//       both be chosen.
//    2. So either you skip the last house, or you skip the first. Every valid
//       plan falls into one of those two cases.
//    3. Run the plain House Robber solver twice, on nums[0..n-2] and on
//       nums[1..n-1], and take the larger. Handle the single-house array
//       separately.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(213)]
public sealed class HouseRobberII : ProblemTests<HouseRobberII>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
