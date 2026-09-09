namespace LeetCodeLab.Practice.Problems.LinkedLists;

// ============================================================================
//  23. Merge k Sorted Lists                                             [Hard]
//  https://leetcode.com/problems/merge-k-sorted-lists/
// ----------------------------------------------------------------------------
//  Merge k sorted linked lists into one sorted list. The array may be empty,
//  and individual lists may be empty (they arrive as null).
//
//  Examples
//    lists = [[1,4,5],[1,3,4],[2,6]]  ->  [1,1,2,3,4,4,5,6]
//    lists = []  ->  []
//    lists = [[]]  ->  []
//
//  Constraints
//    0 <= lists.Length <= 10^4
//    each list is sorted ascending
//
//  Hints (read only as many as you need)
//    1. Solve Merge Two Sorted Lists first; this problem is built on it.
//    2. Folding one list at a time into an accumulator is O(kN) and is a
//       legitimate answer.
//    3. Better: merge in pairs, halving the number of lists each round, for
//       O(N log k). A PriorityQueue over the k current heads also works.
//
//  Aim for O(N log k) time
// ============================================================================
[Problem(23)]
public sealed class MergeKSortedLists : ProblemTests<MergeKSortedLists>
{
    public ListNode? Solve(ListNode?[] lists)
    {
        throw new NotImplementedException();
    }
}
