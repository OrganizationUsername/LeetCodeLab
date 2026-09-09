namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  19. Remove Nth Node From End of List                               [Medium]
//  https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// ----------------------------------------------------------------------------
//  Remove the nth node counting from the end of the list and return the head.
//  n is always valid. Try to do it in one pass.
//
//  Examples
//    head = [1,2,3,4,5], n = 2  ->  [1,2,3,5]
//    head = [1], n = 1  ->  []
//    head = [1,2], n = 1  ->  [1]
//
//  Constraints
//    1 <= list length <= 30
//    1 <= n <= list length
//
//  Hints (read only as many as you need)
//    1. Counting the length first and then walking again works, and is a fine
//       first solution.
//    2. For one pass: start two pointers at the head and move the lead one n
//       steps ahead.
//    3. Now advance both until the lead falls off the end. The trailing
//       pointer is sitting just before the node to unlink. A dummy node
//       before the head removes the special case of deleting the first node.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(19)]
public sealed class RemoveNthNodeFromEndOfList : ProblemTests<RemoveNthNodeFromEndOfList>
{
    public ListNode? Solve(ListNode? head, int n)
    {
        throw new NotImplementedException();
    }
}
