namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  98. Validate Binary Search Tree                                    [Medium]
//  https://leetcode.com/problems/validate-binary-search-tree/
// ----------------------------------------------------------------------------
//  Return true if the tree is a valid binary search tree: every value in a
//  left subtree is strictly less than its node, every value in a right
//  subtree strictly greater, and both subtrees are themselves valid.
//
//  Examples
//    root = [2,1,3]  ->  true
//    root = [5,1,4,null,null,3,6]  ->  false
//    root = [5,4,6,null,null,3,7]  ->  false
//
//  Constraints
//    0 <= node count <= 10^4
//    node values fit in a 32-bit integer
//
//  Hints (read only as many as you need)
//    1. Checking only node against its two children is wrong. A deep
//       descendant can still violate the ordering.
//    2. Carry a permitted open interval down the recursion. The root may be
//       anything; going left tightens the upper bound to the node value,
//       going right tightens the lower bound.
//    3. Use long bounds, or nullable ints, so that a node holding
//       int.MinValue does not produce a false negative.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(98)]
public sealed class ValidateBinarySearchTree : ProblemTests<ValidateBinarySearchTree>
{
    public bool Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
