namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  743. Network Delay Time                                            [Medium]
//  https://leetcode.com/problems/network-delay-time/
// ----------------------------------------------------------------------------
//  Nodes are numbered 1 to n. Each entry [u, v, w] is a one-way link from u
//  to v taking w time. A signal starts at node k. Return the time for every
//  node to receive it, that is the largest of the shortest arrival times, or
//  -1 if some node never receives it.
//
//  Examples
//    times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2  ->  2
//    times = [[1,2,1]], n = 2, k = 1  ->  1
//    times = [[1,2,1]], n = 2, k = 2  ->  -1
//
//  Constraints
//    1 <= n <= 100
//    1 <= times.Length <= 6000
//    edges are DIRECTED and weights are positive
//    nodes are numbered from 1, not 0
//
//  Hints (read only as many as you need)
//    1. Breadth-first search finds the fewest hops, which is not the same as
//       the least time once edges have different weights. You need shortest
//       paths by weight.
//    2. Dijkstra: keep the best known arrival time per node, always expand
//       the unvisited node with the smallest one, and relax its outgoing
//       edges.
//    3. A PriorityQueue of (node, time) does the choosing. Two things to get
//       right: skip an entry when you pop it and it is already worse than the
//       recorded best, and answer -1 if any node is still at infinity. Watch
//       the 1-based numbering against 0-based arrays.
//
//  Aim for O(E log V) time
// ============================================================================
[Problem(743)]
public sealed class NetworkDelayTime : ProblemTests<NetworkDelayTime>
{
    public int Solve(int[][] times, int n, int k)
    {
        throw new NotImplementedException();
    }
}
