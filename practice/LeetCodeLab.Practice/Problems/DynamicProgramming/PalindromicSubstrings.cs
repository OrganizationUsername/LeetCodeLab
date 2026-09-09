namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  647. Palindromic Substrings                                        [Medium]
//  https://leetcode.com/problems/palindromic-substrings/
// ----------------------------------------------------------------------------
//  Count how many substrings of s are palindromes. Substrings at different
//  positions count separately even when they look identical.
//
//  Examples
//    s = "abc"  ->  3
//    s = "aaa"  ->  6
//    s = "aba"  ->  4
//
//  Constraints
//    1 <= s.Length <= 1000
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. Same machinery as Longest Palindromic Substring: expand around every
//       centre.
//    2. There are 2n-1 centres, one per character and one between each
//       adjacent pair.
//    3. Every successful expansion step IS another palindrome, so just count
//       the steps rather than tracking the longest.
//
//  Aim for O(n^2) time, O(1) space
// ============================================================================
[Problem(647)]
public sealed class PalindromicSubstrings : ProblemTests<PalindromicSubstrings>
{
    public int Solve(string s)
    {
        throw new NotImplementedException();
    }
}
