namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  215. Kth Largest Element in an Array                               [Medium]
//  https://leetcode.com/problems/kth-largest-element-in-an-array/
// ----------------------------------------------------------------------------
//  Return the kth largest value by sort order, not the kth distinct value.
//  Duplicates count each time they appear.
//
//  Examples
//    nums = [3,2,1,5,6,4], k = 2  ->  5
//    nums = [3,2,3,1,2,4,5,5,6], k = 4  ->  4
//
//  Constraints
//    1 <= k <= nums.Length <= 10^5
//
//  Hints (read only as many as you need)
//    1. Sorting and indexing from the end is O(n log n) and passes
//       comfortably.
//    2. For O(n log k), keep a min-heap of size k: push everything, and drop
//       the smallest whenever the heap grows past k. The root is then the
//       answer.
//    3. For average O(n), quickselect partitions around a pivot and recurses
//       into only one side.
//
//  Aim for O(n log n) sorting, O(n log k) with a heap
// ============================================================================
[Problem(215)]
public sealed class KthLargestElementInAnArray : ProblemTests<KthLargestElementInAnArray>
{
    public int Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
