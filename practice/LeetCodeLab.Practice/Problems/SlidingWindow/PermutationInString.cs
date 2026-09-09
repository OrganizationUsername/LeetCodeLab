namespace LeetCodeLab.Practice.Problems.SlidingWindow;

// ============================================================================
//  567. Permutation in String                                         [Medium]
//  https://leetcode.com/problems/permutation-in-string/
// ----------------------------------------------------------------------------
//  Return true when s2 contains a contiguous slice that is a rearrangement of
//  s1.
//
//  Examples
//    s1 = "ab", s2 = "eidbaooo"  ->  true
//    s1 = "ab", s2 = "eidboaoo"  ->  false
//    s1 = "adc", s2 = "dcda"  ->  true
//
//  Constraints
//    1 <= s1.Length, s2.Length <= 10^4
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. Any rearrangement of s1 has exactly the same letter counts and
//       exactly the same length.
//    2. So slide a window of s1.Length across s2 and compare letter counts.
//    3. Do not rebuild the counts each step. Add the entering character and
//       remove the leaving one, so each step is O(1) over a 26-slot array.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(567)]
public sealed class PermutationInString : ProblemTests<PermutationInString>
{
    public bool Solve(string s1, string s2)
    {
        throw new NotImplementedException();
    }
}
