namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  167. Two Sum II - Input Array Is Sorted                            [Medium]
//  https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
// ----------------------------------------------------------------------------
//  Like Two Sum, but the array is sorted ascending and the returned indices
//  are ONE-based. Use constant extra space.
//
//  Examples
//    numbers = [2,7,11,15], target = 9  ->  [1,2]
//    numbers = [2,3,4], target = 6  ->  [1,3]
//    numbers = [-1,0], target = -1  ->  [1,2]
//
//  Constraints
//    2 <= numbers.Length <= 3*10^4
//    numbers is sorted ascending
//    exactly one solution exists
//
//  Hints (read only as many as you need)
//    1. Sortedness is the whole gift here. You do not need a dictionary.
//    2. One pointer at each end. Their sum is too small or too large, and
//       that tells you unambiguously which pointer to move.
//    3. Remember to add 1 to each index before returning.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(167)]
public sealed class TwoSumSortedInput : ProblemTests<TwoSumSortedInput>
{
    public int[] Solve(int[] numbers, int target)
    {
        throw new NotImplementedException();
    }
}
