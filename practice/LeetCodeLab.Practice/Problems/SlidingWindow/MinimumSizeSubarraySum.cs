namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  209. Minimum Size Subarray Sum                                     [Medium]
//  https://leetcode.com/problems/minimum-size-subarray-sum/
// ----------------------------------------------------------------------------
//  All values are positive. Return the length of the shortest contiguous
//  slice whose sum is at least target, or 0 if no slice qualifies.
//
//  Examples
//    target = 7, nums = [2,3,1,2,4,3]  ->  2
//    target = 4, nums = [1,4,4]  ->  1
//    target = 11, nums = [1,1,1,1,1,1,1,1]  ->  0
//
//  Constraints
//    1 <= target <= 10^9
//    1 <= nums.Length <= 10^5
//    1 <= nums[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. All values being positive is what makes a sliding window valid:
//       growing the window can only increase the sum.
//    2. Grow the right edge, adding to a running sum.
//    3. While the sum is at least target, record the window length and shrink
//       from the left. Each index enters and leaves once, so this is linear.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(209)]
public sealed class MinimumSizeSubarraySum : ProblemTests<MinimumSizeSubarraySum>
{
    public int Solve(int target, int[] nums)
    {
        throw new NotImplementedException();
    }
}
