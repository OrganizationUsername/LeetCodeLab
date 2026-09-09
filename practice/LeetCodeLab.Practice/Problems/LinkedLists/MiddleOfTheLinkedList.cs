namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  876. Middle of the Linked List                                       [Easy]
//  https://leetcode.com/problems/middle-of-the-linked-list/
// ----------------------------------------------------------------------------
//  Return the middle node of the list. When the length is even there are two
//  middles, and you return the SECOND one.
//
//  Examples
//    head = [1,2,3,4,5]  ->  [3,4,5]
//    head = [1,2,3,4,5,6]  ->  [4,5,6]
//    head = [1]  ->  [1]
//
//  Constraints
//    1 <= list length <= 100
//
//  Hints (read only as many as you need)
//    1. Counting the length then walking half of it is two passes and
//       completely fine.
//    2. For one pass, advance a slow pointer one step and a fast pointer two
//       steps.
//    3. When fast falls off the end, slow is at the middle. Looping while
//       fast and fast.next are both non-null lands on the second middle for
//       even lengths.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(876)]
public sealed class MiddleOfTheLinkedList : ProblemTests<MiddleOfTheLinkedList>
{
    public ListNode? Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
