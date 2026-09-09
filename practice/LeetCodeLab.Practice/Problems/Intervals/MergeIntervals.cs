namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  56. Merge Intervals                                                [Medium]
//  https://leetcode.com/problems/merge-intervals/
// ----------------------------------------------------------------------------
//  Merge every set of overlapping intervals and return the non-overlapping
//  intervals that cover the same span, sorted by start.
//
//  Examples
//    intervals = [[1,3],[2,6],[8,10],[15,18]]  ->  [[1,6],[8,10],[15,18]]
//    intervals = [[1,4],[4,5]]  ->  [[1,5]]
//    intervals = [[1,4],[0,4]]  ->  [[0,4]]
//
//  Constraints
//    1 <= intervals.Length <= 10^4
//    start <= end for every interval
//
//  Hints (read only as many as you need)
//    1. Sort by start first. Almost every interval problem begins this way.
//    2. Then sweep once, holding the interval you are currently building.
//    3. If the next interval starts at or before the current end, extend the
//       current end to the larger of the two. Otherwise close the current one
//       out and start a new one. Touching intervals like [1,4] and [4,5] do
//       merge.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(56)]
public sealed class MergeIntervals : ProblemTests<MergeIntervals>
{
    public int[][] Solve(int[][] intervals)
    {
        throw new NotImplementedException();
    }
}
