namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  111. Minimum Depth of Binary Tree                                    [Easy]
//  https://leetcode.com/problems/minimum-depth-of-binary-tree/
// ----------------------------------------------------------------------------
//  Return the number of nodes on the shortest path from the root down to a
//  LEAF. An empty tree has depth 0.
//
//  Examples
//    root = [3,9,20,null,null,15,7]  ->  2
//    root = [2,null,3,null,4,null,5,null,6]  ->  5
//    root = []  ->  0
//
//  Constraints
//    0 <= node count <= 10^5
//
//  Hints (read only as many as you need)
//    1. The naive mirror of Maximum Depth is wrong: taking min over a missing
//       child returns 0 and reports a fake short path.
//    2. A node with only one child must take that child depth, not the
//       minimum with the null side.
//    3. Handle the three cases explicitly, or use BFS and return the depth of
//       the first leaf you meet, which is faster on skewed trees.
//
//  Aim for O(n) time
// ============================================================================
[Problem(111)]
public sealed class MinimumDepthOfBinaryTree : ProblemTests<MinimumDepthOfBinaryTree>
{
    public int Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
