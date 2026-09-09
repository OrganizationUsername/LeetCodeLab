namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  128. Longest Consecutive Sequence                                  [Medium]
//  https://leetcode.com/problems/longest-consecutive-sequence/
// ----------------------------------------------------------------------------
//  Return the length of the longest run of consecutive integers present in
//  nums. The values need not be adjacent in the array. Sorting solves it, but
//  aim for linear time.
//
//  Examples
//    nums = [100,4,200,1,3,2]  ->  4
//    nums = [0,3,7,2,5,8,4,6,0,1]  ->  9
//    nums = []  ->  0
//
//  Constraints
//    0 <= nums.Length <= 10^5
//    -10^9 <= nums[i] <= 10^9
//
//  Hints (read only as many as you need)
//    1. Put everything in a HashSet so membership is O(1).
//    2. Do not walk a run from the middle: you would walk it once per member,
//       which is quadratic.
//    3. Only start counting at a value n where n-1 is absent. That makes each
//       run walked exactly once.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(128)]
public sealed class LongestConsecutiveSequence : ProblemTests<LongestConsecutiveSequence>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
