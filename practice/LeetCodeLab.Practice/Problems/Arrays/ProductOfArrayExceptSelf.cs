namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  238. Product of Array Except Self                                  [Medium]
//  https://leetcode.com/problems/product-of-array-except-self/
// ----------------------------------------------------------------------------
//  Return an array where result[i] is the product of every element except
//  nums[i]. Division is not allowed, partly because the array may contain
//  zeros.
//
//  Examples
//    nums = [1,2,3,4]  ->  [24,12,8,6]
//    nums = [-1,1,0,-3,3]  ->  [0,0,9,0,0]
//
//  Constraints
//    2 <= nums.Length <= 10^5
//    the answer fits in a 32-bit integer
//
//  Hints (read only as many as you need)
//    1. Everything except position i splits into two independent halves:
//       everything left of i, and everything right of i.
//    2. One left-to-right pass can fill result[i] with the product of
//       everything to its left.
//    3. A second right-to-left pass multiplies in the product of everything
//       to the right, using a single running variable.
//
//  Aim for O(n) time, O(1) extra space beyond the output
// ============================================================================
[Problem(238)]
public sealed class ProductOfArrayExceptSelf : ProblemTests<ProductOfArrayExceptSelf>
{
    public int[] Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
