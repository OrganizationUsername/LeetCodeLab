namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  125. Valid Palindrome                                                [Easy]
//  https://leetcode.com/problems/valid-palindrome/
// ----------------------------------------------------------------------------
//  Return true when the string reads the same forwards and backwards,
//  considering only letters and digits and ignoring case. Everything else is
//  skipped.
//
//  Examples
//    s = "Aman,aplan,acanal:Panama"  ->  true
//    s = "raceacar"  ->  false
//    s = ""  ->  true
//
//  Constraints
//    1 <= s.Length <= 2*10^5
//    printable ASCII
//
//  Hints (read only as many as you need)
//    1. Two pointers, one from each end, walking toward each other.
//    2. Advance each pointer past anything that is not a letter or digit
//       before comparing.
//    3. Compare case-insensitively. char.IsLetterOrDigit and
//       char.ToLowerInvariant do the work.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(125)]
public sealed class ValidPalindrome : ProblemTests<ValidPalindrome>
{
    public bool Solve(string s)
    {
        throw new NotImplementedException();
    }
}
