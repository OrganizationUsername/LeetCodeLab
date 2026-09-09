namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  802. Find Eventual Safe States                                     [Medium]
//  https://leetcode.com/problems/find-eventual-safe-states/
// ----------------------------------------------------------------------------
//  graph[i] lists the nodes reachable in one step from node i, directed. A
//  node is safe when EVERY path leaving it reaches a terminal node - one with
//  no outgoing edges - in a finite number of steps. Return the safe nodes in
//  ascending order.
//
//  Examples
//    graph = [[1,2],[2,3],[5],[0],[5],[],[]]  ->  [2,4,5,6]
//    graph = [[1,2,3,4],[1,2],[3,4],[0,4],[]]  ->  [4]
//    graph = [[]]  ->  [0]
//
//  Constraints
//    1 <= graph.Length <= 10^4
//    the graph is directed and may contain cycles and self-loops
//    return the answer sorted ascending
//
//  Hints (read only as many as you need)
//    1. A node is unsafe exactly when some path from it can enter a cycle. So
//       this is cycle detection, but you need it per starting node rather
//       than as a yes/no for the whole graph.
//    2. Three-colour depth-first search: white unvisited, grey on the current
//       stack, black finished and safe. Meeting a grey node means you closed
//       a cycle.
//    3. A node is safe only if every one of its successors comes back safe.
//       Cache the verdict per node so each is decided once, which is what
//       keeps this linear. The alternative is a topological sort on the
//       REVERSED graph, peeling off terminal nodes.
//
//  Aim for O(nodes + edges) time
// ============================================================================
[Problem(802)]
public sealed class FindEventualSafeStates : ProblemTests<FindEventualSafeStates>
{
    public int[] Solve(int[][] graph)
    {
        throw new NotImplementedException();
    }
}
