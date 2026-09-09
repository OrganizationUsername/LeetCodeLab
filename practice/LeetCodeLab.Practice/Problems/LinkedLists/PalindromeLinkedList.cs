namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  234. Palindrome Linked List                                          [Easy]
//  https://leetcode.com/problems/palindrome-linked-list/
// ----------------------------------------------------------------------------
//  Return true when the list values read the same forwards and backwards.
//
//  Examples
//    head = [1,2,2,1]  ->  true
//    head = [1,2]  ->  false
//    head = [1,2,3,2,1]  ->  true
//
//  Constraints
//    1 <= list length <= 10^5
//
//  Hints (read only as many as you need)
//    1. Copying the values into a List and checking with two indices is O(n)
//       space and perfectly correct.
//    2. For O(1) space, find the middle with slow and fast pointers, then
//       reverse the second half.
//    3. Walk the two halves in step comparing values. The odd-length middle
//       node never needs comparing.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(234)]
public sealed class PalindromeLinkedList : ProblemTests<PalindromeLinkedList>
{
    public bool Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
