namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  205. Isomorphic Strings                                              [Easy]
//  https://leetcode.com/problems/isomorphic-strings/
// ----------------------------------------------------------------------------
//  Two strings are isomorphic when the characters of the first can be
//  replaced to give the second, with every occurrence of a character replaced
//  the same way, and no two different characters mapping to the same one. A
//  character may map to itself.
//
//  Examples
//    s = "egg", t = "add"  ->  true
//    s = "foo", t = "bar"  ->  false
//    s = "paper", t = "title"  ->  true
//
//  Constraints
//    1 <= s.Length == t.Length <= 5*10^4
//    the strings are the same length
//    the mapping must be one-to-one in BOTH directions
//
//  Hints (read only as many as you need)
//    1. One dictionary from s-characters to t-characters is the obvious
//       start, and it is not enough on its own.
//    2. Consider "ab" and "aa". A single forward map happily sends a to a and
//       b to a, but that is two characters collapsing onto one, which is not
//       allowed.
//    3. So keep both directions and reject any conflict in either.
//       Alternatively, compare the sequence of first-occurrence positions of
//       each string - two strings are isomorphic exactly when those match.
//
//  Aim for O(n) time, O(1) space for a fixed alphabet
// ============================================================================
[Problem(205)]
public sealed class IsomorphicStrings : ProblemTests<IsomorphicStrings>
{
    public bool Solve(string s, string t)
    {
        throw new NotImplementedException();
    }
}
