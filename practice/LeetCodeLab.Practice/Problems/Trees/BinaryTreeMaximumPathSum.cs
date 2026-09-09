namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  124. Binary Tree Maximum Path Sum                                    [Hard]
//  https://leetcode.com/problems/binary-tree-maximum-path-sum/
// ----------------------------------------------------------------------------
//  A path is any sequence of nodes connected by edges, in which no node
//  repeats. It need not pass through the root. Return the largest possible
//  sum of the values along such a path.
//
//  Examples
//    root = [1,2,3]  ->  6
//    root = [-10,9,20,null,null,15,7]  ->  42
//    root = [-3]  ->  -3
//
//  Constraints
//    1 <= node count <= 3*10^4
//    -1000 <= node value <= 1000
//
//  Hints (read only as many as you need)
//    1. Two different quantities again. What you RETURN upward is the best
//       path that goes down one side only, because a parent can only extend a
//       single branch.
//    2. What you RECORD is the best path that turns at this node: value +
//       best left branch + best right branch.
//    3. Clamp negative branch contributions to zero, since you are free to
//       not take a branch at all.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(124)]
public sealed class BinaryTreeMaximumPathSum : ProblemTests<BinaryTreeMaximumPathSum>
{
    public int Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
