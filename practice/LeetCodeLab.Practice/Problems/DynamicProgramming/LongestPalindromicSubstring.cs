using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// 5. Longest Palindromic Substring (Medium)
// https://leetcode.com/problems/longest-palindromic-substring/
// "babad" has two correct answers, so the harness calls Validate instead of comparing
// against a single expected string.
[Problem(5)]
public sealed class LongestPalindromicSubstring : ProblemTests<LongestPalindromicSubstring>
{
    public string Solve(string s)
    {
        throw new NotImplementedException();
    }

    /// <summary>Any palindromic substring of s matching the known best length is accepted.</summary>
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
