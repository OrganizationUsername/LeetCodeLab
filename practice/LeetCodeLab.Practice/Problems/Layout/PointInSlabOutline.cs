namespace LeetCodeLab.Practice.Problems.Layout;

// ============================================================================
//  9014. Point in Slab Outline                                        [Medium]
// ----------------------------------------------------------------------------
//  A slab edge is a simple closed polygon, given as vertices in order with
//  the closing edge implied. Decide whether a load point lies on the slab. A
//  point exactly on an edge or exactly on a vertex counts as on the slab,
//  because a column on the slab edge is still on the slab.
//
//  Examples
//    polygon = [[0,0],[4,0],[4,4],[0,4]], point = [2,2]  ->  true
//    polygon = [[0,0],[4,0],[4,4],[0,4]], point = [5,2]  ->  false
//    polygon = [[0,0],[4,0],[4,4],[0,4]], point = [0,0]  ->  true
//
//  Constraints
//    3 <= polygon.Length <= 10^5
//    the polygon is simple and may be convex or concave, wound either way
//    coordinates are integers, so boundary cases can be decided exactly
//
//  Hints (read only as many as you need)
//    1. Handle the boundary first and separately. Walk the edges and test
//       whether the point lies on any of them; only then worry about inside
//       versus outside.
//    2. For the interior test, fire a ray from the point - straight along +x
//       is easiest - and count how many edges it crosses. Odd means inside.
//    3. Getting the crossing rule right is the whole problem: an edge counts
//       when exactly one of its endpoints is strictly above the ray, which is
//       the half-open convention that stops a vertex on the ray being counted
//       twice. Compare with cross products on integers rather than computing
//       an intersection in floating point.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(9014)]
public sealed class PointInSlabOutline : ProblemTests<PointInSlabOutline>
{
    public bool Solve(int[][] polygon, int[] point)
    {
        throw new NotImplementedException();
    }
}
