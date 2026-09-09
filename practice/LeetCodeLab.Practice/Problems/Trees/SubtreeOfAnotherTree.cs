namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  572. Subtree of Another Tree                                         [Easy]
//  https://leetcode.com/problems/subtree-of-another-tree/
// ----------------------------------------------------------------------------
//  Return true when some node of root has a subtree identical in structure
//  and values to subRoot.
//
//  Examples
//    root = [3,4,5,1,2], subRoot = [4,1,2]  ->  true
//    root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]  ->  false
//
//  Constraints
//    1 <= root node count <= 2000
//    1 <= subRoot node count <= 1000
//
//  Hints (read only as many as you need)
//    1. You already have the tool: an equality check between two trees, which
//       is Same Tree.
//    2. At every node of root, ask whether the tree rooted here equals
//       subRoot.
//    3. If not, recurse into both children. TreeNodes.Equal in
//       LeetCodeLab.Core does the equality half for you.
//
//  Aim for O(n * m) time
// ============================================================================
[Problem(572)]
public sealed class SubtreeOfAnotherTree : ProblemTests<SubtreeOfAnotherTree>
{
    public bool Solve(TreeNode? root, TreeNode? subRoot)
    {
        throw new NotImplementedException();
    }
}
