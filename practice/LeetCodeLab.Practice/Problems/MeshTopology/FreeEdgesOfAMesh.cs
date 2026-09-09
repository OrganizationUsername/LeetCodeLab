namespace LeetCodeLab.Practice.Problems.MeshTopology;

// ============================================================================
//  9003. Free Edges of a Mesh                                         [Medium]
// ----------------------------------------------------------------------------
//  A surface mesh is given as triangles, each three node numbers. An interior
//  edge is shared by two triangles; a free edge belongs to exactly one.
//  Return every free edge as a pair [a, b]. Free edges trace the outline of
//  the mesh and any holes in it, so an empty answer means the surface is
//  closed. The order of the edges, and the order within a pair, do not
//  matter.
//
//  Examples
//    triangles = [[0,1,2],[0,2,3]]  ->  [[0,1],[1,2],[2,3],[0,3]]
//    triangles = [[0,1,2]]  ->  [[0,1],[0,2],[1,2]]
//    triangles = [[0,1,2],[0,1,3],[0,2,3],[1,2,3]]  ->  []
//
//  Constraints
//    1 <= triangles.Length <= 10^5
//    node numbers are non-negative and a triangle never repeats one
//    no edge is shared by more than two triangles
//
//  Hints (read only as many as you need)
//    1. Comparing every triangle against every other is quadratic. You only
//       ever need to know how many triangles touched a given edge.
//    2. The catch is that triangle [0,1,2] and triangle [2,1,3] both contain
//       the edge between nodes 1 and 2, written in opposite directions. Those
//       must count as the same edge.
//    3. Normalise each edge to (min, max) before using it as a dictionary
//       key, tally the three edges of every triangle, then return the keys
//       whose count is 1.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(9003)]
public sealed class FreeEdgesOfAMesh : ProblemTests<FreeEdgesOfAMesh>
{
    public int[][] Solve(int[][] triangles)
    {
        throw new NotImplementedException();
    }
}
