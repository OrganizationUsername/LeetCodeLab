namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  83. Remove Duplicates from Sorted List                               [Easy]
//  https://leetcode.com/problems/remove-duplicates-from-sorted-list/
// ----------------------------------------------------------------------------
//  The list is sorted ascending. Delete nodes so each value appears once, and
//  return the head.
//
//  Examples
//    head = [1,1,2]  ->  [1,2]
//    head = [1,1,2,3,3]  ->  [1,2,3]
//    head = []  ->  []
//
//  Constraints
//    0 <= list length <= 300
//    the list is sorted ascending
//
//  Hints (read only as many as you need)
//    1. Because the list is sorted, duplicates are always adjacent.
//    2. Walk a single pointer. When the next node holds the same value,
//       unlink it by skipping over it.
//    3. Do NOT advance in that case: the new next node might be a duplicate
//       too.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(83)]
public sealed class RemoveDuplicatesFromSortedList : ProblemTests<RemoveDuplicatesFromSortedList>
{
    public ListNode? Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
