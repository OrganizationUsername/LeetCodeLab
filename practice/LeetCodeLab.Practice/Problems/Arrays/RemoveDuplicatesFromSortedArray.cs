namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  26. Remove Duplicates from Sorted Array                              [Easy]
//  https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// ----------------------------------------------------------------------------
//  The array is sorted. Remove duplicates in place so each value appears
//  once, and return the count k of unique values. Only the first k slots are
//  checked; whatever is left beyond them is ignored.
//
//  Examples
//    nums = [1,1,2]  ->  2, with the first 2 entries [1,2]
//    nums = [0,0,1,1,1,2,2,3,3,4]  ->  5, with the first 5 entries [0,1,2,3,4]
//
//  Constraints
//    1 <= nums.Length <= 3*10^4
//    nums is sorted ascending
//
//  Hints (read only as many as you need)
//    1. You cannot resize a C# array, which is exactly why the answer is a
//       count.
//    2. Keep a write cursor separate from the read cursor. Only advance the
//       write cursor when you see something new.
//    3. Because the array is sorted, new just means different from the last
//       value you wrote.
//
//  Aim for O(n) time, O(1) extra space
// ============================================================================
[Problem(26)]
public sealed class RemoveDuplicatesFromSortedArray : ProblemTests<RemoveDuplicatesFromSortedArray>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
