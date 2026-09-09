namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  141. Linked List Cycle                                               [Easy]
//  https://leetcode.com/problems/linked-list-cycle/
// ----------------------------------------------------------------------------
//  Return true if the list contains a cycle. The test data specifies the
//  cycle with a position index, and the harness wires the tail back before
//  calling you; your method just receives the head.
//
//  Examples
//    head = [3,2,0,-4]  ->  true
//    head = [1,2]  ->  true
//    head = [1]  ->  false
//
//  Constraints
//    0 <= list length <= 10^4
//
//  Hints (read only as many as you need)
//    1. A HashSet of visited nodes works and is O(n) space.
//    2. For O(1) space, run a slow pointer one step at a time and a fast
//       pointer two steps at a time.
//    3. If there is a cycle the fast pointer laps the slow one and they meet.
//       If there is not, the fast pointer reaches null. Compare by reference,
//       not by value.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(141)]
public sealed class LinkedListCycle : ProblemTests<LinkedListCycle>
{
    public bool Solve(ListNode? head)
    {
        throw new NotImplementedException();
    }
}
