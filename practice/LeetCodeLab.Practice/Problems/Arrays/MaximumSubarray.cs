namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  53. Maximum Subarray                                               [Medium]
//  https://leetcode.com/problems/maximum-subarray/
// ----------------------------------------------------------------------------
//  Return the largest sum obtainable from a contiguous non-empty slice of
//  nums. Values may be negative.
//
//  Examples
//    nums = [-2,1,-3,4,-1,2,1,-5,4]  ->  6
//    nums = [1]  ->  1
//    nums = [5,4,-1,7,8]  ->  23
//
//  Constraints
//    1 <= nums.Length <= 10^5
//    -10^4 <= nums[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. Walk left to right holding the best sum of a slice that ends exactly
//       at the current index.
//    2. Extending the previous slice is only worth it while that running sum
//       is positive. Otherwise start fresh at the current element.
//    3. This is the Kadane recurrence: running = max(x, running + x), and
//       track the best running value seen.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(53)]
public sealed class MaximumSubarray : ProblemTests<MaximumSubarray>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
