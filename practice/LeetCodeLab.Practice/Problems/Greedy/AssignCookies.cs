namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  455. Assign Cookies                                                  [Easy]
//  https://leetcode.com/problems/assign-cookies/
// ----------------------------------------------------------------------------
//  g holds each child's greed factor and s holds each cookie's size. A child
//  is content when given one cookie at least as big as their greed factor.
//  Each child gets at most one cookie and each cookie goes to at most one
//  child. Return the greatest number of content children.
//
//  Examples
//    g = [1,2,3], s = [1,1]  ->  1
//    g = [1,2], s = [1,2,3]  ->  2
//    g = [10,9,8,7], s = [5,6,7,8]  ->  2
//
//  Constraints
//    1 <= g.Length <= 3*10^4
//    0 <= s.Length <= 3*10^4, so there may be no cookies at all
//    one cookie per child, one child per cookie
//
//  Hints (read only as many as you need)
//    1. Sort both. Then the question is which cookie to give to which child,
//       and the greedy rule is about not wasting the big ones.
//    2. Serve the least greedy child with the smallest cookie that satisfies
//       them. Spending a larger cookie there can only cost you later.
//    3. Two pointers walking the two sorted arrays: advance the cookie
//       pointer always, and the child pointer only when the current cookie is
//       big enough.
//
//  Aim for O(n log n + m log m) time
// ============================================================================
[Problem(455)]
public sealed class AssignCookies : ProblemTests<AssignCookies>
{
    public int Solve(int[] g, int[] s)
    {
        throw new NotImplementedException();
    }
}
