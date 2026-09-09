namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  143. Reorder List                                                  [Medium]
//  https://leetcode.com/problems/reorder-list/
// ----------------------------------------------------------------------------
//  Reorder the list in place so it interleaves front and back: first, last,
//  second, second-last, and so on. Return nothing; the list itself is
//  checked.
//
//  Examples
//    head = [1,2,3,4]  ->  head becomes [1,4,2,3]
//    head = [1,2,3,4,5]  ->  head becomes [1,5,2,4,3]
//
//  Constraints
//    1 <= list length <= 5*10^4
//
//  Hints (read only as many as you need)
//    1. Three classic sub-problems in sequence.
//    2. First find the midpoint with slow and fast pointers, and cut the list
//       in two.
//    3. Reverse the second half, then weave the two halves together one node
//       at a time. Remember to null out the first half tail before reversing,
//       or you build a cycle.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(143)]
public sealed class ReorderList : ProblemTests<ReorderList>
{
    public void Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
