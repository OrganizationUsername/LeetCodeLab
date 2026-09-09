namespace LeetCodeLab.Practice.Problems.PlaneGeometry;

// ============================================================================
//  149. Max Points on a Line                                            [Hard]
//  https://leetcode.com/problems/max-points-on-a-line/
// ----------------------------------------------------------------------------
//  Given distinct points on a plane, return the greatest number of them that
//  lie on one straight line.
//
//  Examples
//    points = [[1,1],[2,2],[3,3]]  ->  3
//    points = [[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]  ->  4
//    points = [[0,0]]  ->  1
//
//  Constraints
//    1 <= points.Length <= 300
//    -10^4 <= x, y <= 10^4
//    all points are distinct
//
//  Hints (read only as many as you need)
//    1. Any line through two or more of these points passes through at least
//       one of them, so you can afford to anchor on each point in turn.
//    2. Anchored at point p, two other points are on the same line through p
//       exactly when they share a direction from p. Count directions and keep
//       the biggest bucket.
//    3. Do not key the bucket on a double slope: dy/dx loses precision and
//       blows up on vertical lines. Reduce (dx, dy) by their gcd and force a
//       canonical sign, then use that pair as the key.
//
//  Aim for O(n^2) time, O(n) space
// ============================================================================
[Problem(149)]
public sealed class MaxPointsOnALine : ProblemTests<MaxPointsOnALine>
{
    public int Solve(int[][] points)
    {
        throw new NotImplementedException();
    }
}
