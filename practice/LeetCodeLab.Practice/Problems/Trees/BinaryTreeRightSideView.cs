namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  199. Binary Tree Right Side View                                   [Medium]
//  https://leetcode.com/problems/binary-tree-right-side-view/
// ----------------------------------------------------------------------------
//  Imagine standing to the right of the tree. Return the values you can see,
//  ordered top to bottom: that is, the rightmost node of each level.
//
//  Examples
//    root = [1,2,3,null,5,null,4]  ->  [1,3,4]
//    root = [1,null,3]  ->  [1,3]
//    root = []  ->  []
//
//  Constraints
//    0 <= node count <= 100
//
//  Hints (read only as many as you need)
//    1. This is level-order traversal with only one value kept per level.
//    2. Do a BFS, recording the size of each level, and take the LAST node
//       you dequeue from it.
//    3. A DFS also works if you visit right before left and record the first
//       node reached at each new depth.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(199)]
public sealed class BinaryTreeRightSideView : ProblemTests<BinaryTreeRightSideView>
{
    public IList<int> Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
