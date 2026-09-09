namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  21. Merge Two Sorted Lists                                           [Easy]
//  https://leetcode.com/problems/merge-two-sorted-lists/
// ----------------------------------------------------------------------------
//  Both lists are sorted ascending. Splice their nodes together into one
//  sorted list and return its head. Reuse the existing nodes rather than
//  allocating new ones.
//
//  Examples
//    list1 = [1,2,4], list2 = [1,3,4]  ->  [1,1,2,3,4,4]
//    list1 = [], list2 = []  ->  []
//    list1 = [], list2 = [0]  ->  [0]
//
//  Constraints
//    0 <= each list length <= 50
//    both sorted ascending
//
//  Hints (read only as many as you need)
//    1. A dummy head node saves you from special-casing the very first
//       append.
//    2. Repeatedly take the smaller of the two front nodes and append it,
//       advancing that list.
//    3. When one list runs out the other is already sorted, so append it
//       wholesale rather than looping.
//
//  Aim for O(n + m) time, O(1) space
// ============================================================================
[Problem(21)]
public sealed class MergeTwoSortedLists : ProblemTests<MergeTwoSortedLists>
{
    public ListNode? Solve(ListNode? list1, ListNode? list2)
    {
        throw new NotImplementedException();
    }
}
