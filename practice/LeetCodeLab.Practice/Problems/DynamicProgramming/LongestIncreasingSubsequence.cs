namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  300. Longest Increasing Subsequence                                [Medium]
//  https://leetcode.com/problems/longest-increasing-subsequence/
// ----------------------------------------------------------------------------
//  Return the length of the longest strictly increasing subsequence. The
//  chosen elements keep their relative order but need not be adjacent.
//
//  Examples
//    nums = [10,9,2,5,3,7,101,18]  ->  4
//    nums = [0,1,0,3,2,3]  ->  4
//    nums = [7,7,7,7,7,7,7]  ->  1
//
//  Constraints
//    1 <= nums.Length <= 2500 on the examples, 100000 on the stress case
//
//  Hints (read only as many as you need)
//    1. The O(n^2) DP, where length[i] is the best subsequence ending at i,
//       is the natural first solution. It will not survive the stress case.
//    2. For O(n log n), keep a list where tails[L] is the smallest possible
//       tail of an increasing subsequence of length L+1. That list is always
//       sorted.
//    3. For each value, binary search for its insertion point: replace if it
//       lands inside, append if it is larger than everything. The answer is
//       the final list length.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(300)]
public sealed class LongestIncreasingSubsequence : ProblemTests<LongestIncreasingSubsequence>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
