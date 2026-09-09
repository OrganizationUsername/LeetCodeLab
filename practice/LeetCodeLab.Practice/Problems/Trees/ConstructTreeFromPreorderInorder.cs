namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  105. Construct Binary Tree from Preorder and Inorder Traversal     [Medium]
//  https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
// ----------------------------------------------------------------------------
//  Rebuild the binary tree from its preorder and inorder traversals. All
//  values are distinct.
//
//  Examples
//    preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]  ->  [3,9,20,null,null,15,7]
//    preorder = [-1], inorder = [-1]  ->  [-1]
//    preorder = [1,2], inorder = [2,1]  ->  [1,2]
//
//  Constraints
//    1 <= preorder.Length <= 3000
//    the two arrays describe the same tree
//    all values distinct
//
//  Hints (read only as many as you need)
//    1. The FIRST element of a preorder slice is always the root of that
//       subtree.
//    2. Find that value inside the inorder slice: everything to its left is
//       the left subtree, everything to its right is the right subtree, and
//       the sizes tell you how to split the preorder slice.
//    3. Recurse on the two halves. A Dictionary from value to inorder index
//       turns the search into O(1) and the whole thing into O(n).
//
//  Aim for O(n) time with an index map
// ============================================================================
[Problem(105)]
public sealed class ConstructTreeFromPreorderInorder : ProblemTests<ConstructTreeFromPreorderInorder>
{
    public TreeNode? Solve(int[] preorder, int[] inorder)
    {
        throw new NotImplementedException();
    }
}
