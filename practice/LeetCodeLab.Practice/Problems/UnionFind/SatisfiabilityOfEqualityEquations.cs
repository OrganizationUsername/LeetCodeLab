namespace LeetCodeLab.Practice.Problems.UnionFind;

// ============================================================================
//  990. Satisfiability of Equality Equations                          [Medium]
//  https://leetcode.com/problems/satisfiability-of-equality-equations/
// ----------------------------------------------------------------------------
//  Each equation is four characters: a lowercase letter, then == or !=, then
//  another lowercase letter. Decide whether integers can be assigned to the
//  letters so that every equation holds at once.
//
//  Examples
//    equations = ["a==b","b!=a"]  ->  false
//    equations = ["b==a","a==b"]  ->  true
//    equations = ["a==b","b==c","a==c"]  ->  true
//
//  Constraints
//    1 <= equations.Length <= 500
//    each equation has the form "a==b" or "a!=b"
//    letters are lowercase a-z
//
//  Hints (read only as many as you need)
//    1. Equality is transitive and inequality is not, so the two kinds of
//       equation are not symmetric. Order matters.
//    2. Merge everything the equalities force to be equal first, then check
//       the inequalities against the result.
//    3. Union the == pairs into 26 disjoint sets, then a != pair is a
//       contradiction exactly when both letters landed in the same set.
//
//  Aim for O(n a(n)) time, O(1) space
// ============================================================================
[Problem(990)]
public sealed class SatisfiabilityOfEqualityEquations : ProblemTests<SatisfiabilityOfEqualityEquations>
{
    public bool Solve(string[] equations)
    {
        throw new NotImplementedException();
    }
}
