namespace LeetCodeLab.Practice.Problems.MeshTopology;

// ============================================================================
//  9006. Load Path to Ground                                            [Easy]
// ----------------------------------------------------------------------------
//  Nodes 0..n-1 are joined by members, and some nodes are supported. A node
//  is grounded when a chain of members leads from it to any support. Anything
//  not grounded is floating: the analysis will fail on it, or worse, quietly
//  return nonsense. Return the floating node numbers in ascending order, or
//  an empty list if every node is grounded.
//
//  Examples
//    n = 5, members = [[0,1],[1,2],[3,4]], supports = [0]  ->  [3,4]
//    n = 3, members = [[0,1],[1,2]], supports = [2]  ->  []
//    n = 4, members = [], supports = [0]  ->  [1,2,3]
//
//  Constraints
//    1 <= n <= 10^5
//    0 <= members.Length <= 2*10^5
//    members are undirected and join two different nodes
//    supports may be empty, in which case every node is floating
//
//  Hints (read only as many as you need)
//    1. This is reachability, but not from one starting node - from any of
//       several at once.
//    2. You do not need a separate search per support. Push every support
//       into the queue before the loop starts and run one traversal.
//    3. Breadth-first or depth-first both work; mark nodes visited as you
//       enqueue them, not as you dequeue them, or a cycle will let you queue
//       the same node twice. Whatever stays unmarked is the answer.
//
//  Aim for O(n + m) time, O(n + m) space
// ============================================================================
[Problem(9006)]
public sealed class LoadPathToGround : ProblemTests<LoadPathToGround>
{
    public int[] Solve(int n, int[][] members, int[] supports)
    {
        throw new NotImplementedException();
    }
}
