namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  100. Same Tree                                                       [Easy]
//  https://leetcode.com/problems/same-tree/
// ----------------------------------------------------------------------------
//  Return true when the two trees have identical structure and identical
//  values at every position.
//
//  Examples
//    p = [1,2,3], q = [1,2,3]  ->  true
//    p = [1,2], q = [1,null,2]  ->  false
//    p = [1,2,1], q = [1,1,2]  ->  false
//
//  Constraints
//    0 <= node count <= 100
//
//  Hints (read only as many as you need)
//    1. Handle the null cases first: both null is true, exactly one null is
//       false.
//    2. Otherwise the values must match and both pairs of subtrees must
//       match.
//    3. That is a three-line recursion once the null case is out of the way.
//
//  Aim for O(n) time, O(h) space
// ============================================================================
[Problem(100)]
public sealed class SameTree : ProblemTests<SameTree>
{
    public bool Solve(TreeNode? p, TreeNode? q)
    {
        throw new NotImplementedException();
    }
}
