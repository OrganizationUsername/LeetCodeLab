namespace LeetCodeLab.Practice.Problems.MeshTopology;

// ============================================================================
//  9005. Minimum Bandwidth Numbering                                    [Hard]
// ----------------------------------------------------------------------------
//  A banded solver stores the stiffness matrix out to its furthest non-zero,
//  so the cost depends on how the nodes were numbered. For a given numbering,
//  the bandwidth is the largest difference between the two numbers of any
//  member. Renumber the nodes however you like - every node gets a distinct
//  number from 0 to n-1 - and return the smallest bandwidth achievable. With
//  no members at all the bandwidth is 0.
//
//  Examples
//    n = 4, members = [[0,1],[1,2],[2,3]]  ->  1
//    n = 4, members = [[0,1],[0,2],[0,3]]  ->  2
//    n = 4, members = [[0,1],[0,2],[0,3],[1,2],[1,3],[2,3]]  ->  3
//
//  Constraints
//    1 <= n <= 8
//    0 <= members.Length <= n*(n-1)/2
//    members join two different nodes and are not repeated
//    n is small on purpose: this problem is NP-hard in general
//
//  Hints (read only as many as you need)
//    1. n is at most 8. That is a very deliberate bound - it is telling you
//       that searching every numbering is on the table, and that no clever
//       formula is expected.
//    2. 8! is 40320, so generate the permutations of 0..n-1, score each by
//       the largest member span it produces, and keep the best.
//    3. You can prune hard if you want: build the numbering position by
//       position and abandon a partial numbering the moment its span already
//       reaches the best complete answer so far. Real solvers give up on the
//       exact answer entirely and use a heuristic like reverse Cuthill-McKee
//       - this problem is why.
//
//  Aim for O(n! * m) time without pruning
// ============================================================================
[Problem(9005)]
public sealed class MinimumBandwidthNumbering : ProblemTests<MinimumBandwidthNumbering>
{
    public int Solve(int n, int[][] members)
    {
        throw new NotImplementedException();
    }
}
