namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  230. Kth Smallest Element in a BST                                 [Medium]
//  https://leetcode.com/problems/kth-smallest-element-in-a-bst/
// ----------------------------------------------------------------------------
//  The tree is a valid BST. Return its kth smallest value, counting from 1.
//
//  Examples
//    root = [3,1,4,null,2], k = 1  ->  1
//    root = [5,3,6,2,4,null,null,1], k = 3  ->  3
//
//  Constraints
//    1 <= k <= node count <= 10^4
//
//  Hints (read only as many as you need)
//    1. An in-order traversal of a BST visits values in ascending order. That
//       is the entire insight.
//    2. So you want the kth node produced by an in-order walk.
//    3. Rather than collecting everything, count as you go and stop at k. An
//       explicit stack lets you bail out early without unwinding recursion.
//
//  Aim for O(h + k) time
// ============================================================================
[Problem(230)]
public sealed class KthSmallestElementInABst : ProblemTests<KthSmallestElementInABst>
{
    public int Solve(TreeNode? root, int k)
    {
        throw new NotImplementedException();
    }
}
