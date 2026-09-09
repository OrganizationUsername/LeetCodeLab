namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  3. Longest Substring Without Repeating Characters                  [Medium]
//  https://leetcode.com/problems/longest-substring-without-repeating-characters/
// ----------------------------------------------------------------------------
//  Return the length of the longest contiguous run of characters in which no
//  character repeats.
//
//  Examples
//    s = "abcabcbb"  ->  3
//    s = "bbbbb"  ->  1
//    s = "pwwkew"  ->  3
//
//  Constraints
//    0 <= s.Length <= 5*10^4
//    letters, digits, symbols and spaces
//
//  Hints (read only as many as you need)
//    1. Maintain a window from start to i that is always free of repeats.
//    2. When s[i] has been seen before AND its last position is inside the
//       window, jump start to just past that position.
//    3. A Dictionary from character to its most recent index makes that jump
//       O(1). Never move start backwards.
//
//  Aim for O(n) time, O(min(n, alphabet)) space
// ============================================================================
[Problem(3)]
public sealed class LongestSubstringWithoutRepeatingCharacters : ProblemTests<LongestSubstringWithoutRepeatingCharacters>
{
    public int Solve(string s)
    {
        throw new NotImplementedException();
    }
}
