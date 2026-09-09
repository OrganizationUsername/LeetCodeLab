namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  110. Balanced Binary Tree                                            [Easy]
//  https://leetcode.com/problems/balanced-binary-tree/
// ----------------------------------------------------------------------------
//  Return true when the tree is height-balanced, meaning that at every node
//  the two subtree heights differ by at most one.
//
//  Examples
//    root = [3,9,20,null,null,15,7]  ->  true
//    root = [1,2,2,3,3,null,null,4,4]  ->  false
//    root = []  ->  true
//
//  Constraints
//    0 <= node count <= 5000
//
//  Hints (read only as many as you need)
//    1. Computing height separately at every node re-walks the tree and gives
//       O(n^2).
//    2. Instead have one recursion return the height AND signal imbalance in
//       the same pass.
//    3. A common trick is returning -1 as a sentinel for already unbalanced,
//       which then propagates straight up.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(110)]
public sealed class BalancedBinaryTree : ProblemTests<BalancedBinaryTree>
{
    public bool Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
