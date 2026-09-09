namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  112. Path Sum                                                        [Easy]
//  https://leetcode.com/problems/path-sum/
// ----------------------------------------------------------------------------
//  Return true when some root-to-LEAF path has values summing to targetSum. A
//  leaf is a node with no children; stopping partway down does not count.
//
//  Examples
//    root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22  ->  true
//    root = [1,2,3], targetSum = 5  ->  false
//    root = [], targetSum = 0  ->  false
//
//  Constraints
//    0 <= node count <= 5000
//    values may be negative
//
//  Hints (read only as many as you need)
//    1. Carry the remaining target down the recursion, subtracting each node
//       value.
//    2. The success test happens at a leaf: no children left AND the
//       remainder is exactly zero.
//    3. The empty tree is false. Be careful not to treat a node with one
//       child as a leaf.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(112)]
public sealed class PathSum : ProblemTests<PathSum>
{
    public bool Solve(TreeNode? root, int targetSum)
    {
        throw new NotImplementedException();
    }
}
