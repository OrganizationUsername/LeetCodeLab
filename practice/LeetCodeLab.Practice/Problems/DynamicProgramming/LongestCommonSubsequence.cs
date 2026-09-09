namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  1143. Longest Common Subsequence                                   [Medium]
//  https://leetcode.com/problems/longest-common-subsequence/
// ----------------------------------------------------------------------------
//  Return the length of the longest subsequence common to both strings. A
//  subsequence keeps relative order but need not be contiguous.
//
//  Examples
//    text1 = "abcde", text2 = "ace"  ->  3
//    text1 = "abc", text2 = "abc"  ->  3
//    text1 = "abc", text2 = "def"  ->  0
//
//  Constraints
//    1 <= each length <= 1000
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. This is the classic two-dimensional table. best[i][j] is the answer
//       for the first i characters of one string and the first j of the
//       other.
//    2. If the two current characters match, best[i][j] = best[i-1][j-1] + 1.
//    3. If they do not, you must drop one character from one side: best[i][j]
//       = max(best[i-1][j], best[i][j-1]).
//
//  Aim for O(n*m) time
// ============================================================================
[Problem(1143)]
public sealed class LongestCommonSubsequence : ProblemTests<LongestCommonSubsequence>
{
    public int Solve(string text1, string text2)
    {
        throw new NotImplementedException();
    }
}
