namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  543. Diameter of Binary Tree                                         [Easy]
//  https://leetcode.com/problems/diameter-of-binary-tree/
// ----------------------------------------------------------------------------
//  Return the length of the longest path between any two nodes, measured in
//  edges. The path does not have to pass through the root.
//
//  Examples
//    root = [1,2,3,4,5]  ->  3
//    root = [1,2]  ->  1
//    root = [1]  ->  0
//
//  Constraints
//    1 <= node count <= 10^4
//
//  Hints (read only as many as you need)
//    1. For any node, the longest path THROUGH it is leftHeight + rightHeight
//       edges.
//    2. So compute heights recursively, and while doing so track the best
//       value of that sum anywhere.
//    3. The answer is that running maximum, not the return value of the
//       recursion. Those are two different quantities.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(543)]
public sealed class DiameterOfBinaryTree : ProblemTests<DiameterOfBinaryTree>
{
    public int Solve(TreeNode? root)
    {
        throw new NotImplementedException();
    }
}
