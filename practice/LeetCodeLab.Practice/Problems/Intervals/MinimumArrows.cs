namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  452. Minimum Number of Arrows to Burst Balloons                    [Medium]
//  https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/
// ----------------------------------------------------------------------------
//  Each balloon spans [start, end] on a horizontal line. An arrow fired
//  straight up at x bursts every balloon whose span contains x, endpoints
//  included. Return the fewest arrows that burst them all.
//
//  Examples
//    points = [[10,16],[2,8],[1,6],[7,12]]  ->  2
//    points = [[1,2],[3,4],[5,6],[7,8]]  ->  4
//    points = [[1,2],[2,3],[3,4],[4,5]]  ->  2
//
//  Constraints
//    1 <= points.Length <= 10^5
//    -2^31 <= start <= end <= 2^31 - 1
//    touching at an endpoint counts as overlapping, so [1,2] and [2,3] share an arrow
//
//  Hints (read only as many as you need)
//    1. This is the maximum number of pairwise non-overlapping balloons in
//       disguise: each of those needs its own arrow.
//    2. Sort by END coordinate, not by start. Then repeatedly fire at the
//       earliest end you have not yet covered.
//    3. Firing at the smallest end is optimal because any balloon that arrow
//       misses starts after that point anyway. Sort by end, keep the last
//       arrow position, and add an arrow whenever a balloon starts strictly
//       after it. Beware sorting by subtracting the two ends - that overflows
//       on the extreme coordinates here; use a comparison instead.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(452)]
public sealed class MinimumArrows : ProblemTests<MinimumArrows>
{
    public int Solve(int[][] points)
    {
        throw new NotImplementedException();
    }
}
