namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  88. Merge Sorted Array                                               [Easy]
//  https://leetcode.com/problems/merge-sorted-array/
// ----------------------------------------------------------------------------
//  nums1 has length m + n: the first m slots hold its values and the trailing
//  n slots are zero padding. nums2 holds n values. Merge them into nums1 in
//  sorted order, in place. Nothing is returned; nums1 itself is checked.
//
//  Examples
//    nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3  ->  nums1 becomes [1,2,2,3,5,6]
//    nums1 = [1], m = 1, nums2 = [], n = 0  ->  nums1 becomes [1]
//    nums1 = [0], m = 0, nums2 = [1], n = 1  ->  nums1 becomes [1]
//
//  Constraints
//    nums1.Length == m + n
//    nums2.Length == n
//    both inputs are sorted ascending
//
//  Hints (read only as many as you need)
//    1. Merging front to back forces you to shift elements out of the way.
//    2. Fill from the BACK instead. The last slot of nums1 is free, and you
//       always know the largest remaining value.
//    3. Walk three cursors backwards: one in each source, one writing. If
//       nums2 empties first you are done, because the rest of nums1 is
//       already in place.
//
//  Aim for O(m + n) time, O(1) space
// ============================================================================
[Problem(88)]
public sealed class MergeSortedArray : ProblemTests<MergeSortedArray>
{
    public void Solve(int[] nums1, int m, int[] nums2, int n)
    {
        throw new NotImplementedException();
    }
}
