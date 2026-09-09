namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  28. Find the Index of the First Occurrence in a String               [Easy]
//  https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
// ----------------------------------------------------------------------------
//  Return the index of the first occurrence of needle in haystack, or -1 when
//  it does not occur.
//
//  Examples
//    haystack = "sadbutsad", needle = "sad"  ->  0
//    haystack = "leetcode", needle = "leeto"  ->  -1
//    haystack = "hello", needle = "ll"  ->  2
//
//  Constraints
//    1 <= haystack.Length, needle.Length <= 10^4
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. The straightforward approach tries every starting position and
//       compares forward.
//    2. That is O(n*m), which is fine at these limits.
//    3. If you want to go further, look up Knuth-Morris-Pratt, which
//       precomputes how far to jump on a mismatch to reach O(n + m).
//
//  Aim for O(n*m) time naively, O(n+m) with KMP
// ============================================================================
[Problem(28)]
public sealed class FirstOccurrenceInString : ProblemTests<FirstOccurrenceInString>
{
    public int Solve(string haystack, string needle)
    {
        throw new NotImplementedException();
    }
}
