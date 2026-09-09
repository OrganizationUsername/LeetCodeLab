namespace LeetCodeLab.Practice.Problems.UnionFind;

// ============================================================================
//  684. Redundant Connection                                          [Medium]
//  https://leetcode.com/problems/redundant-connection/
// ----------------------------------------------------------------------------
//  You are given a tree with one extra edge added, so the graph has n nodes
//  numbered 1..n and exactly n edges. Exactly one cycle exists. Return the
//  edge that can be removed to leave a tree. If several edges would work,
//  return the one that appears last in the input.
//
//  Examples
//    edges = [[1,2],[1,3],[2,3]]  ->  [2,3]
//    edges = [[1,2],[2,3],[3,4],[1,4],[1,5]]  ->  [1,4]
//    edges = [[1,4],[3,4],[1,3],[1,2],[4,5]]  ->  [1,3]
//
//  Constraints
//    n == edges.Length, 3 <= n <= 1000
//    the graph is connected and has exactly one cycle
//    no self-loops and no repeated edges
//
//  Hints (read only as many as you need)
//    1. Process the edges in order. The moment an edge joins two nodes that
//       were already reachable from each other, that edge closed the cycle.
//    2. You need a structure that answers 'are these two already connected?'
//       while you add edges one at a time.
//    3. Disjoint set union: a parent array, Find with path compression, Union
//       by size. If Find(a) == Find(b) before you union, this edge is the
//       answer.
//
//  Aim for O(n a(n)) time, O(n) space
// ============================================================================
[Problem(684)]
public sealed class RedundantConnection : ProblemTests<RedundantConnection>
{
    public int[] Solve(int[][] edges)
    {
        throw new NotImplementedException();
    }
}
