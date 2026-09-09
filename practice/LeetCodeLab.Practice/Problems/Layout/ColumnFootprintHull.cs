namespace LeetCodeLab.Practice.Problems.Layout;

// ============================================================================
//  9013. Column Footprint Hull                                          [Hard]
// ----------------------------------------------------------------------------
//  Given the column locations on a floor plate, return the smallest convex
//  outline containing them all - the shape a rubber band would take around
//  the set. List the hull vertices counter-clockwise, starting at the point
//  with the smallest x and, among ties, the smallest y. Leave out any point
//  that falls in the middle of a hull edge rather than at a corner. If every
//  point is collinear return just the two extreme ones, and if there is a
//  single point return only it.
//
//  Examples
//    points = [[0,0],[4,0],[4,4],[0,4],[2,2]]  ->  [[0,0],[4,0],[4,4],[0,4]]
//    points = [[0,0],[2,0],[4,0],[0,4]]  ->  [[0,0],[4,0],[0,4]]
//    points = [[0,0],[1,1]]  ->  [[0,0],[1,1]]
//
//  Constraints
//    1 <= points.Length <= 10^5
//    coordinates are integers, so all the arithmetic can stay exact
//    points are distinct
//
//  Hints (read only as many as you need)
//    1. Deciding whether a point is a corner needs a turn test, not an angle.
//       For three points in order, the cross product of the two edge vectors
//       is positive for a left turn, negative for a right turn, and zero when
//       they are collinear.
//    2. Sort the points by x, then by y. Sweep left to right building the
//       lower boundary, then sweep back right to left building the upper one,
//       and join them.
//    3. While building each chain, pop the previous point whenever it fails
//       to make a strict left turn - that single rule discards both concave
//       corners and points sitting on an edge. Use long for the cross
//       product; the coordinates are small here but this is the line that
//       overflows in real code.
//
//  Aim for O(n log n) time, O(n) space
// ============================================================================
[Problem(9013)]
public sealed class ColumnFootprintHull : ProblemTests<ColumnFootprintHull>
{
    public int[][] Solve(int[][] points)
    {
        throw new NotImplementedException();
    }
}
