namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  57. Insert Interval                                                [Medium]
//  https://leetcode.com/problems/insert-interval/
// ----------------------------------------------------------------------------
//  The intervals are already sorted by start and do not overlap. Insert
//  newInterval, merging where necessary, and return the result still sorted
//  and non-overlapping.
//
//  Examples
//    intervals = [[1,3],[6,9]], newInterval = [2,5]  ->  [[1,5],[6,9]]
//    intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]  ->  [[1,2],[3,10],[12,16]]
//    intervals = [], newInterval = [5,7]  ->  [[5,7]]
//
//  Constraints
//    0 <= intervals.Length <= 10^4
//    intervals are sorted by start and disjoint
//
//  Hints (read only as many as you need)
//    1. The input is already sorted, so no sort is needed and the whole thing
//       is O(n).
//    2. Three phases: copy everything ending strictly before the new interval
//       starts, then absorb everything that overlaps, then copy the rest.
//    3. While absorbing, widen the new interval to the min of the starts and
//       the max of the ends. Emit it once the overlapping run is done.
//
//  Aim for O(n) time
// ============================================================================
[Problem(57)]
public sealed class InsertInterval : ProblemTests<InsertInterval>
{
    public int[][] Solve(int[][] intervals, int[] newInterval)
    {
        throw new NotImplementedException();
    }
}
