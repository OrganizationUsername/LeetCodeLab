namespace LeetCodeLab.Practice.Problems.SectionProperties;

// ============================================================================
//  9001. Polygon Section Properties                                   [Medium]
// ----------------------------------------------------------------------------
//  A cross-section is given as a simple closed polygon: a list of (x, y)
//  vertices in order, with the closing edge from the last back to the first
//  implied. Return its area and centroid as [area, cx, cy]. The winding may
//  be clockwise or counter-clockwise and the area you return must be positive
//  either way.
//
//  Examples
//    vertices = [[0,0],[4,0],[4,4],[0,4]]  ->  [16,2,2]
//    vertices = [[0,0],[0,4],[4,4],[4,0]]  ->  [16,2,2]
//    vertices = [[0,0],[6,0],[0,3]]  ->  [9,2,1]
//
//  Constraints
//    3 <= vertices.Length <= 1000
//    the polygon is simple: edges meet only at shared vertices
//    coordinates fit comfortably in a double
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Chopping the shape into triangles or trapezoids and adding them up
//       works, but there is a closed form that needs one pass and no case
//       analysis.
//    2. Walk the edges. Each edge from (xi, yi) to (xj, yj) contributes a
//       cross product xi*yj - xj*yi. Half the sum of those is the SIGNED
//       area, and the sign is exactly the winding direction.
//    3. Reuse each cross term for the centroid: cx = sum((xi + xj) * cross) /
//       (6 * signedArea), and cy the same with (yi + yj). Divide by the
//       SIGNED area here, then take the absolute value only at the very end,
//       or a clockwise polygon comes out mirrored.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(9001)]
public sealed class PolygonSectionProperties : ProblemTests<PolygonSectionProperties>
{
    public double[] Solve(double[][] vertices)
    {
        throw new NotImplementedException();
    }
}
