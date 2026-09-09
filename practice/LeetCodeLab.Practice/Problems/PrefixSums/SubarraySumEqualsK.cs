namespace LeetCodeLab.Practice.Problems.PrefixSums;

// ============================================================================
//  560. Subarray Sum Equals K                                         [Medium]
//  https://leetcode.com/problems/subarray-sum-equals-k/
// ----------------------------------------------------------------------------
//  Count the contiguous subarrays whose values sum to exactly k. Values may
//  be negative, so a sliding window does not work here.
//
//  Examples
//    nums = [1,1,1], k = 2  ->  2
//    nums = [1,2,3], k = 3  ->  2
//    nums = [1,-1,0], k = 0  ->  3
//
//  Constraints
//    1 <= nums.Length <= 2*10^4
//    -1000 <= nums[i] <= 1000
//    -10^7 <= k <= 10^7
//    the sliding-window trick needs non-negative values; this problem does not have them
//
//  Hints (read only as many as you need)
//    1. Write P[j] for the sum of the first j elements. The subarray from i
//       to j-1 sums to P[j] - P[i].
//    2. So you want to count pairs i < j with P[j] - P[i] == k. Rearranged:
//       for each j, how many earlier prefixes equal P[j] - k?
//    3. One pass, a running sum, and a Dictionary from prefix value to how
//       many times you have seen it. Seed it with 0 mapped to 1 so subarrays
//       starting at index 0 get counted.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(560)]
public sealed class SubarraySumEqualsK : ProblemTests<SubarraySumEqualsK>
{
    public int Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
