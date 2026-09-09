namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  435. Non-overlapping Intervals                                     [Medium]
//  https://leetcode.com/problems/non-overlapping-intervals/
// ----------------------------------------------------------------------------
//  Return the minimum number of intervals you must remove so that the rest do
//  not overlap. Intervals that merely touch at an endpoint do not count as
//  overlapping.
//
//  Examples
//    intervals = [[1,2],[2,3],[3,4],[1,3]]  ->  1
//    intervals = [[1,2],[1,2],[1,2]]  ->  2
//    intervals = [[1,2],[2,3]]  ->  0
//
//  Constraints
//    1 <= intervals.Length <= 10^5
//    start < end for every interval
//
//  Hints (read only as many as you need)
//    1. Removing the fewest is the same as KEEPING the most, which is the
//       classic activity selection problem.
//    2. Sort by END, not by start. Always keeping the interval that finishes
//       earliest leaves the most room for the rest.
//    3. Sweep, keeping an interval whenever its start is at or after the last
//       kept end. The answer is the total minus the number kept.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(435)]
public sealed class NonOverlappingIntervals : ProblemTests<NonOverlappingIntervals>
{
    public int Solve(int[][] intervals)
    {
        throw new NotImplementedException();
    }
}
