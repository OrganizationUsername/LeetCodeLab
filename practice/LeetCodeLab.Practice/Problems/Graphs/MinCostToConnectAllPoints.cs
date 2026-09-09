namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  1584. Min Cost to Connect All Points                               [Medium]
//  https://leetcode.com/problems/min-cost-to-connect-all-points/
// ----------------------------------------------------------------------------
//  Every pair of points can be joined at a cost equal to their Manhattan
//  distance, the sum of the absolute differences in x and y. Return the least
//  total cost to connect all the points so that any point is reachable from
//  any other.
//
//  Examples
//    points = [[0,0],[2,2],[3,10],[5,2],[7,0]]  ->  20
//    points = [[3,12],[-2,5],[-4,1]]  ->  18
//    points = [[0,0]]  ->  0
//
//  Constraints
//    1 <= points.Length <= 1000
//    -10^6 <= x, y <= 10^6
//    the graph is complete: every pair is a candidate edge
//    a single point costs 0
//
//  Hints (read only as many as you need)
//    1. Connecting everything as cheaply as possible with no redundant links
//       is a minimum spanning tree. n-1 edges, no cycles.
//    2. Because every pair is joinable, the graph is dense with n^2 edges.
//       That favours Prim's algorithm over sorting all the edges for Kruskal.
//    3. Prim: keep the cheapest known distance from the growing tree to each
//       outside point, repeatedly absorb the nearest one, then update its
//       neighbours. An O(n^2) array version beats a heap here, since the edge
//       count is already n^2.
//
//  Aim for O(n^2) time with Prim
// ============================================================================
[Problem(1584)]
public sealed class MinCostToConnectAllPoints : ProblemTests<MinCostToConnectAllPoints>
{
    public int Solve(int[][] points)
    {
        throw new NotImplementedException();
    }
}
