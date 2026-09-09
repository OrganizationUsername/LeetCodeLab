namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  1288. Remove Covered Intervals                                     [Medium]
//  https://leetcode.com/problems/remove-covered-intervals/
// ----------------------------------------------------------------------------
//  Interval [a, b) is covered by [c, d) when c <= a and b <= d. Remove every
//  covered interval and return how many remain.
//
//  Examples
//    intervals = [[1,4],[3,6],[2,8]]  ->  2
//    intervals = [[1,4],[2,3]]  ->  1
//    intervals = [[0,10],[5,12]]  ->  2
//
//  Constraints
//    1 <= intervals.Length <= 1000
//    0 <= left < right <= 10^5
//    all intervals are distinct as given, but one may still cover another
//    an interval covers itself only trivially and is not removed for it
//
//  Hints (read only as many as you need)
//    1. Sort so that a covering interval is always seen BEFORE the one it
//       covers. Then one pass with a running maximum end is enough.
//    2. Sort by start ascending. Ties need care: when two intervals share a
//       start, the longer one covers the shorter, so it must come first -
//       sort ties by end DESCENDING.
//    3. Then walk keeping the largest end seen. An interval is covered
//       exactly when its end is <= that maximum. Without the descending
//       tie-break, equal starts get counted twice.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(1288)]
public sealed class RemoveCoveredIntervals : ProblemTests<RemoveCoveredIntervals>
{
    public int Solve(int[][] intervals)
    {
        throw new NotImplementedException();
    }
}
