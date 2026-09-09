namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  617. Merge Two Binary Trees                                          [Easy]
//  https://leetcode.com/problems/merge-two-binary-trees/
// ----------------------------------------------------------------------------
//  Overlay the two trees. Where both have a node, the merged value is their
//  sum. Where only one has a node, that subtree is used as is. Return the
//  merged tree.
//
//  Examples
//    root1 = [1,3,2,5], root2 = [2,1,3,null,4,null,7]  ->  [3,4,5,5,4,null,7]
//    root1 = [1], root2 = [1,2]  ->  [2,2]
//    root1 = [], root2 = [1]  ->  [1]
//
//  Constraints
//    0 <= node count <= 2000 in each tree
//
//  Hints (read only as many as you need)
//    1. If either node is null, the answer at that position is simply the
//       other one.
//    2. Otherwise create a node holding the sum and recurse into both left
//       pairs and both right pairs.
//    3. You may build a fresh tree or mutate one in place; either is
//       accepted.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(617)]
public sealed class MergeTwoBinaryTrees : ProblemTests<MergeTwoBinaryTrees>
{
    public TreeNode? Solve(TreeNode? root1, TreeNode? root2)
    {
        throw new NotImplementedException();
    }
}
