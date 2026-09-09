namespace LeetCodeLab.Practice.Problems.MeshTopology;

// ============================================================================
//  9004. Merge Coincident Nodes                                       [Medium]
// ----------------------------------------------------------------------------
//  Geometry imported from several drawings has nodes that should be one node
//  but sit a hair apart. Two nodes are coincident when the distance between
//  them is at most the tolerance, and coincidence spreads: if A merges with B
//  and B merges with C then A, B and C all become one node, even if A and C
//  are further apart than the tolerance. Return how many distinct nodes
//  remain after merging.
//
//  Examples
//    points = [[0,0],[0,0.001],[5,5]], tolerance = 0.01  ->  2
//    points = [[0,0],[0.6,0],[1.2,0]], tolerance = 0.7  ->  1
//    points = [[0,0],[1,0],[2,0]], tolerance = 0.5  ->  3
//
//  Constraints
//    1 <= points.Length <= 2000
//    points are 2D, given as [x, y]
//    tolerance > 0
//    distance is straight-line, and exactly equal to the tolerance still merges
//
//  Hints (read only as many as you need)
//    1. The obvious approach is to snap every coordinate onto a grid of
//       tolerance-sized cells and count the distinct cells. Try that on three
//       points spaced 0.6 apart with a tolerance of 0.7 and see what it does.
//    2. Merging is transitive, which is what breaks snapping: a chain of
//       nodes each within tolerance of the next is a single node however long
//       the chain gets.
//    3. That is exactly a connected-components question. Union every pair
//       within tolerance and count the surviving roots. Compare squared
//       distances against the squared tolerance and you never need a square
//       root.
//
//  Aim for O(n^2 a(n)) time, O(n) space
// ============================================================================
[Problem(9004)]
public sealed class MergeCoincidentNodes : ProblemTests<MergeCoincidentNodes>
{
    public int Solve(double[][] points, double tolerance)
    {
        throw new NotImplementedException();
    }
}
