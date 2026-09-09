namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  424. Longest Repeating Character Replacement                       [Medium]
//  https://leetcode.com/problems/longest-repeating-character-replacement/
// ----------------------------------------------------------------------------
//  You may change at most k characters to any uppercase letter. Return the
//  length of the longest run of a single repeated letter you can produce.
//
//  Examples
//    s = "ABAB", k = 2  ->  4
//    s = "AABABBA", k = 1  ->  4
//
//  Constraints
//    1 <= s.Length <= 10^5
//    uppercase English letters
//    0 <= k <= s.Length
//
//  Hints (read only as many as you need)
//    1. A window is valid when window length minus the count of its most
//       common letter is at most k, since that difference is how many changes
//       it needs.
//    2. Grow the window one character at a time, keeping 26 letter counts.
//    3. When the window becomes invalid, shrink from the left. The answer is
//       the largest valid window seen.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(424)]
public sealed class LongestRepeatingCharacterReplacement : ProblemTests<LongestRepeatingCharacterReplacement>
{
    public int Solve(string s, int k)
    {
        throw new NotImplementedException();
    }
}
