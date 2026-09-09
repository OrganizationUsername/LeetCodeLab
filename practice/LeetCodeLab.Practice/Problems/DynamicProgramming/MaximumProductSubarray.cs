namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  152. Maximum Product Subarray                                      [Medium]
//  https://leetcode.com/problems/maximum-product-subarray/
// ----------------------------------------------------------------------------
//  Return the largest product obtainable from a contiguous non-empty slice of
//  nums.
//
//  Examples
//    nums = [2,3,-2,4]  ->  6
//    nums = [-2,0,-1]  ->  0
//    nums = [-2,3,-4]  ->  24
//
//  Constraints
//    1 <= nums.Length <= 2*10^4
//    the answer fits in a 32-bit integer
//
//  Hints (read only as many as you need)
//    1. The Kadane trick does not transfer directly, because a large negative
//       product becomes large and positive when multiplied by another
//       negative.
//    2. So track BOTH the maximum and the minimum product ending at the
//       current index.
//    3. On a negative value the two swap roles. Compute both from the old
//       pair before overwriting either.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(152)]
public sealed class MaximumProductSubarray : ProblemTests<MaximumProductSubarray>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
