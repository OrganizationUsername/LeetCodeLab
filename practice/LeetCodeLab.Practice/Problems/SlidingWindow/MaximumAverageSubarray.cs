namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  643. Maximum Average Subarray I                                      [Easy]
//  https://leetcode.com/problems/maximum-average-subarray-i/
// ----------------------------------------------------------------------------
//  Return the maximum average value over any contiguous slice of exactly
//  length k. Answers are compared to within 1e-5.
//
//  Examples
//    nums = [1,12,-5,-6,50,3], k = 4  ->  12.75
//    nums = [5], k = 1  ->  5.0
//    nums = [0,4,0,3,2], k = 1  ->  4.0
//
//  Constraints
//    1 <= k <= nums.Length <= 10^5
//    -10^4 <= nums[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. The window length is fixed, so maximising the average is the same as
//       maximising the sum.
//    2. Sum the first k values, then slide: add the entering value and
//       subtract the leaving one.
//    3. Divide once at the end, and divide by a double so you do not
//       truncate.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(643)]
public sealed class MaximumAverageSubarray : ProblemTests<MaximumAverageSubarray>
{
    public double Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
