namespace LeetCodeLab.Practice.Problems.UnionFind;

// ============================================================================
//  1319. Number of Operations to Make Network Connected               [Medium]
//  https://leetcode.com/problems/number-of-operations-to-make-network-connected/
// ----------------------------------------------------------------------------
//  There are n computers numbered 0..n-1 joined by ethernet cables. You may
//  unplug any cable and replug it between any two computers. Return the
//  fewest moves that make every computer reachable from every other, or -1 if
//  it cannot be done.
//
//  Examples
//    n = 4, connections = [[0,1],[0,2],[1,2]]  ->  1
//    n = 6, connections = [[0,1],[0,2],[0,3],[1,2],[1,3]]  ->  2
//    n = 6, connections = [[0,1],[0,2],[0,3],[1,2]]  ->  -1
//
//  Constraints
//    1 <= n <= 10^5
//    0 <= connections.Length <= 10^5
//    no duplicate cables and no self-loops
//
//  Hints (read only as many as you need)
//    1. Before writing any code, ask how many cables it takes at minimum to
//       connect n computers. If you have fewer than that, no amount of
//       rearranging helps.
//    2. A cable is spare exactly when it joins two computers that were
//       already connected. Count those while you build the components.
//    3. With c components you need c-1 moves, and you have enough spare
//       cables as long as connections.Length >= n-1. Then the answer is c-1.
//
//  Aim for O(n + m) time, O(n) space
// ============================================================================
[Problem(1319)]
public sealed class MakeNetworkConnected : ProblemTests<MakeNetworkConnected>
{
    public int Solve(int n, int[][] connections)
    {
        throw new NotImplementedException();
    }
}
