namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  785. Is Graph Bipartite?                                           [Medium]
//  https://leetcode.com/problems/is-graph-bipartite/
// ----------------------------------------------------------------------------
//  graph[i] lists the neighbours of node i in an undirected graph. Decide
//  whether the nodes can be split into two groups so that every edge joins a
//  node in one group to a node in the other.
//
//  Examples
//    graph = [[1,2,3],[0,2],[0,1,3],[0,2]]  ->  false
//    graph = [[1,3],[0,2],[1,3],[0,2]]  ->  true
//    graph = [[]]  ->  true
//
//  Constraints
//    1 <= graph.Length <= 100
//    the graph is undirected, has no self-loops and no repeated edges
//    it may be disconnected, so every component must be checked
//
//  Hints (read only as many as you need)
//    1. Two groups means two colours. Walk the graph colouring as you go,
//       giving every neighbour the opposite colour to the node you came from.
//    2. A conflict appears the moment you meet an already-coloured neighbour
//       holding the SAME colour as the current node. That is an odd cycle,
//       and odd cycles are exactly what stops a graph being bipartite.
//    3. The graph may be disconnected, so start a fresh search from every
//       uncoloured node rather than only from node 0. Breadth-first with a
//       colour array of -1, 0, 1 is the least fiddly version.
//
//  Aim for O(nodes + edges) time
// ============================================================================
[Problem(785)]
public sealed class IsGraphBipartite : ProblemTests<IsGraphBipartite>
{
    public bool Solve(int[][] graph)
    {
        throw new NotImplementedException();
    }
}
