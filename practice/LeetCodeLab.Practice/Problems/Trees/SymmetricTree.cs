namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  101. Symmetric Tree                                                  [Easy]
//  https://leetcode.com/problems/symmetric-tree/
// ----------------------------------------------------------------------------
//  Return true when the tree is a mirror image of itself about its centre
//  line.
//
//  Examples
//    root = [1,2,2,3,4,4,3]  ->  true
//    root = [1,2,2,null,3,null,3]  ->  false
//    root = [1]  ->  true
//
//  Constraints
//    1 <= node count <= 1000
//
//  Hints (read only as many as you need)
//    1. This is not the same as comparing a tree with itself. You need a
//       mirrored comparison.
//    2. Write a helper taking TWO nodes and asking whether they are mirrors
//       of each other.
//    3. Two nodes mirror when their values match AND left mirrors the other
//       right, and right mirrors the other left. Start it on root.left and
//       root.right.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(101)]
public sealed class SymmetricTree : ProblemTests<SymmetricTree>
{
    public bool Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
