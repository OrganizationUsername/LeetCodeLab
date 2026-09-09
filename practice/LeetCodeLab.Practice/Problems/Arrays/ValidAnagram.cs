namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  242. Valid Anagram                                                   [Easy]
//  https://leetcode.com/problems/valid-anagram/
// ----------------------------------------------------------------------------
//  Return true when t is a rearrangement of s, using exactly the same letters
//  the same number of times.
//
//  Examples
//    s = "anagram", t = "nagaram"  ->  true
//    s = "rat", t = "car"  ->  false
//    s = "a", t = "ab"  ->  false
//
//  Constraints
//    1 <= s.Length, t.Length <= 5*10^4
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. Different lengths can be rejected immediately.
//    2. Count how many times each character occurs in s, then decrement while
//       walking t.
//    3. If a decrement would take a count below zero, or a character is
//       missing entirely, it is not an anagram.
//
//  Aim for O(n) time, O(1) space (26 counters)
// ============================================================================
[Problem(242)]
public sealed class ValidAnagram : ProblemTests<ValidAnagram>
{
    public bool Solve(string s, string t)
    {
        throw new NotImplementedException();
    }
}
