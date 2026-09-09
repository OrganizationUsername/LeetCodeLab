namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  92. Reverse Linked List II                                         [Medium]
//  https://leetcode.com/problems/reverse-linked-list-ii/
// ----------------------------------------------------------------------------
//  Reverse only the nodes from position left to position right inclusive,
//  counting from 1, and return the head. Try it in one pass.
//
//  Examples
//    head = [1,2,3,4,5], left = 2, right = 4  ->  [1,4,3,2,5]
//    head = [5], left = 1, right = 1  ->  [5]
//    head = [1,2,3], left = 1, right = 3  ->  [3,2,1]
//
//  Constraints
//    1 <= list length <= 500
//    1 <= left <= right <= list length
//
//  Hints (read only as many as you need)
//    1. A dummy node before the head removes the special case where left is
//       1.
//    2. Walk to the node just BEFORE position left and hold on to it. That is
//       your anchor.
//    3. Then repeatedly lift the node after the current one and splice it in
//       directly after the anchor. Doing that right minus left times reverses
//       the section in place.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(92)]
public sealed class ReverseLinkedListII : ProblemTests<ReverseLinkedListII>
{
    public ListNode? Solve(ListNode? head, int left, int right)
    {
        throw new NotImplementedException();
    }
}
