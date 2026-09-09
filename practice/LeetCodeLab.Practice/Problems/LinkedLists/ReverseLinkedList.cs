namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  206. Reverse Linked List                                             [Easy]
//  https://leetcode.com/problems/reverse-linked-list/
// ----------------------------------------------------------------------------
//  Reverse the list and return the new head. Handle the empty list.
//
//  Examples
//    head = [1,2,3,4,5]  ->  [5,4,3,2,1]
//    head = [1,2]  ->  [2,1]
//    head = []  ->  []
//
//  Constraints
//    0 <= list length <= 5000
//
//  Hints (read only as many as you need)
//    1. You need three references: the node before, the node you are on, and
//       the node after.
//    2. Capture next BEFORE you overwrite the current node next pointer, or
//       you lose the rest of the list.
//    3. When the loop ends, the previous pointer is the new head.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(206)]
public sealed class ReverseLinkedList : ProblemTests<ReverseLinkedList>
{
    public ListNode? Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
