namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  226. Invert Binary Tree                                              [Easy]
//  https://leetcode.com/problems/invert-binary-tree/
// ----------------------------------------------------------------------------
//  Mirror the tree left to right and return the root.
//
//  Examples
//    root = [4,2,7,1,3,6,9]  ->  [4,7,2,9,6,3,1]
//    root = [2,1,3]  ->  [2,3,1]
//    root = []  ->  []
//
//  Constraints
//    0 <= node count <= 100
//
//  Hints (read only as many as you need)
//    1. At each node, its two subtrees swap places.
//    2. Invert each subtree, then assign them to the opposite sides.
//    3. Careful with the swap: assigning left before you have read the old
//       left loses it. Tuple assignment does it safely in one statement.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(226)]
public sealed class InvertBinaryTree : ProblemTests<InvertBinaryTree>
{
    public TreeNode? Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
