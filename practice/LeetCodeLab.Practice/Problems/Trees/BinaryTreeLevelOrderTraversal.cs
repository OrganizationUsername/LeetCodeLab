namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  102. Binary Tree Level Order Traversal                             [Medium]
//  https://leetcode.com/problems/binary-tree-level-order-traversal/
// ----------------------------------------------------------------------------
//  Return the node values level by level, top to bottom and left to right
//  within each level. An empty tree returns an empty list.
//
//  Examples
//    root = [3,9,20,null,null,15,7]  ->  [[3],[9,20],[15,7]]
//    root = [1]  ->  [[1]]
//    root = []  ->  []
//
//  Constraints
//    0 <= node count <= 2000
//
//  Hints (read only as many as you need)
//    1. This is breadth-first search with one extra detail: you must know
//       where each level ends.
//    2. Before draining the queue, record its current Count. That count is
//       exactly the width of the current level.
//    3. Process precisely that many nodes into one list, enqueuing children
//       as you go, then start the next level.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(102)]
public sealed class BinaryTreeLevelOrderTraversal : ProblemTests<BinaryTreeLevelOrderTraversal>
{
    public IList<IList<int>> Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
