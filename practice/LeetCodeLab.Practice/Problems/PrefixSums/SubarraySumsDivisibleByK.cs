namespace LeetCodeLab.Practice.Problems.PrefixSums;

// ============================================================================
//  974. Subarray Sums Divisible by K                                  [Medium]
//  https://leetcode.com/problems/subarray-sums-divisible-by-k/
// ----------------------------------------------------------------------------
//  Count the contiguous subarrays whose sum is a multiple of k. A sum of zero
//  counts as a multiple.
//
//  Examples
//    nums = [4,5,0,-2,-3,1], k = 5  ->  7
//    nums = [5], k = 9  ->  0
//    nums = [-1,2,9], k = 2  ->  2
//
//  Constraints
//    1 <= nums.Length <= 3*10^4
//    -10^4 <= nums[i] <= 10^4
//    2 <= k <= 10^4
//
//  Hints (read only as many as you need)
//    1. Same prefix-sum setup as counting sums equal to k, but the condition
//       is now that P[j] - P[i] is divisible by k.
//    2. That holds exactly when P[j] and P[i] leave the same remainder. So
//       group the prefixes by remainder and count the pairs inside each
//       group.
//    3. C# gives a negative result for % on a negative number, so normalise
//       the remainder into 0..k-1 first. Then an int array of k counts is all
//       you need, and each group of c prefixes contributes c*(c-1)/2.
//
//  Aim for O(n) time, O(k) space
// ============================================================================
[Problem(974)]
public sealed class SubarraySumsDivisibleByK : ProblemTests<SubarraySumsDivisibleByK>
{
    public int Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
