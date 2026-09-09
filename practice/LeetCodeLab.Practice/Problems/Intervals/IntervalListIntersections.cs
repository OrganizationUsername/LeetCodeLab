namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  986. Interval List Intersections                                   [Medium]
//  https://leetcode.com/problems/interval-list-intersections/
// ----------------------------------------------------------------------------
//  Both lists are sorted and internally disjoint. Return every intersection
//  between an interval of the first list and one of the second, in sorted
//  order. Intervals that merely touch at a point still intersect, producing a
//  single-point interval.
//
//  Examples
//    firstList = [[0,2],[5,10],[13,23],[24,25]], secondList = [[1,5],[8,12],[15,24],[25,26]]  ->  [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
//    firstList = [[1,3],[5,9]], secondList = []  ->  []
//    firstList = [], secondList = [[4,8],[10,12]]  ->  []
//
//  Constraints
//    0 <= list lengths <= 1000
//    each list is sorted ascending and its own intervals never overlap
//    either list may be empty, in which case the answer is empty
//    [1,3] and [3,5] intersect at [3,3]
//
//  Hints (read only as many as you need)
//    1. Comparing every pair is O(n*m) and ignores that both lists are
//       already sorted.
//    2. Two pointers, one per list. The intersection of the two current
//       intervals, if any, runs from the larger start to the smaller end.
//    3. That candidate is real exactly when start <= end. Then advance the
//       pointer whose interval ENDS first, because it can never intersect
//       anything later in the other list.
//
//  Aim for O(n + m) time
// ============================================================================
[Problem(986)]
public sealed class IntervalListIntersections : ProblemTests<IntervalListIntersections>
{
    public int[][] Solve(int[][] firstList, int[][] secondList)
    {
        throw new NotImplementedException();
    }
}
