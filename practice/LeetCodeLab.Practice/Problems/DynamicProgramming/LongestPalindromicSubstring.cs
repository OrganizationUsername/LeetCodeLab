using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  5. Longest Palindromic Substring                                   [Medium]
//  https://leetcode.com/problems/longest-palindromic-substring/
// ----------------------------------------------------------------------------
//  Return the longest contiguous substring of s that is a palindrome. Several
//  answers can tie, and any of the longest is accepted.
//
//  Examples
//    s = "babad"  ->  "bab"  (other answers may also be accepted)
//    s = "cbbd"  ->  "bb"  (other answers may also be accepted)
//    s = "a"  ->  "a"  (other answers may also be accepted)
//
//  Constraints
//    1 <= s.Length <= 1000
//
//  Hints (read only as many as you need)
//    1. Every palindrome has a centre. There are 2n-1 of them: one at each
//       character, and one between each adjacent pair.
//    2. From each centre, expand outward while the characters match, and
//       remember the longest span you achieve.
//    3. Handle odd and even length palindromes as two separate expansions
//       from each index.
//
//  Aim for O(n^2) time, O(1) space
// ============================================================================
[Problem(5)]
public sealed class LongestPalindromicSubstring : ProblemTests<LongestPalindromicSubstring>
{
    public string Solve(string s)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Harness plumbing, not part of your solution: several answers can be correct,
    /// so any palindromic substring of s with the known best length is accepted.
    /// </summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        string input = (string)args[0]!;
        if (actual is not string answer) return false;
        if (answer.Length != expected.GetString()!.Length) return false;
        if (!input.Contains(answer, StringComparison.Ordinal)) return false;

        for (int i = 0, j = answer.Length - 1; i < j; i++, j--)
            if (answer[i] != answer[j]) return false;

        return true;
    }
}
