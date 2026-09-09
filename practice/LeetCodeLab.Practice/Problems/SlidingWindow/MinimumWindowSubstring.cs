namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  76. Minimum Window Substring                                         [Hard]
//  https://leetcode.com/problems/minimum-window-substring/
// ----------------------------------------------------------------------------
//  Return the shortest slice of s containing every character of t, counting
//  repeats. Return an empty string when no such slice exists. The answer is
//  unique.
//
//  Examples
//    s = "ADOBECODEBANC", t = "ABC"  ->  "BANC"
//    s = "a", t = "a"  ->  "a"
//    s = "a", t = "aa"  ->  ""
//
//  Constraints
//    1 <= s.Length, t.Length <= 10^5
//    upper and lower case English letters
//
//  Hints (read only as many as you need)
//    1. Count what t requires. Then grow a window to the right until it
//       satisfies every requirement.
//    2. Track how many distinct characters are currently satisfied rather
//       than re-comparing the whole count table each step.
//    3. Once the window is valid, shrink from the left while it stays valid,
//       recording the best. Then resume growing. Each index moves at most
//       twice.
//
//  Aim for O(n + m) time
// ============================================================================
[Problem(76)]
public sealed class MinimumWindowSubstring : ProblemTests<MinimumWindowSubstring>
{
    public string Solve(string s, string t)
    {
        throw new NotImplementedException();
    }
}
