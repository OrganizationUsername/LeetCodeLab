namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  2. Add Two Numbers                                                 [Medium]
//  https://leetcode.com/problems/add-two-numbers/
// ----------------------------------------------------------------------------
//  Two non-negative integers are stored as linked lists with their digits in
//  REVERSE order, one digit per node. Add them and return the sum in the same
//  reversed form.
//
//  Examples
//    l1 = [2,4,3], l2 = [5,6,4]  ->  [7,0,8]
//    l1 = [0], l2 = [0]  ->  [0]
//    l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]  ->  [8,9,9,9,0,0,0,1]
//
//  Constraints
//    1 <= each list length <= 100
//    0 <= node value <= 9
//    no leading zeros except the number 0
//
//  Hints (read only as many as you need)
//    1. Reverse order is a gift: you meet the least significant digits first,
//       which is where addition starts.
//    2. Walk both lists together holding a carry, and keep going while either
//       list has nodes left OR the carry is non-zero.
//    3. Treat a missing node as digit 0. A dummy head node keeps the append
//       loop uniform.
//
//  Aim for O(max(n, m)) time
// ============================================================================
[Problem(2)]
public sealed class AddTwoNumbers : ProblemTests<AddTwoNumbers>
{
    public ListNode? Solve(ListNode? l1, ListNode? l2)
    {
        throw new NotImplementedException();
    }
}
