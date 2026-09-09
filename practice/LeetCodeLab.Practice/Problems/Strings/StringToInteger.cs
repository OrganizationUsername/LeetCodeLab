namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  8. String to Integer (atoi)                                        [Medium]
//  https://leetcode.com/problems/string-to-integer-atoi/
// ----------------------------------------------------------------------------
//  Convert the leading number of a string to a 32-bit signed integer. Skip
//  any leading spaces, accept one optional + or - sign, then read digits
//  until a non-digit or the end. Anything after that is ignored. If no digits
//  were read the answer is 0. Clamp results outside the signed 32-bit range
//  to its minimum or maximum.
//
//  Examples
//    s = "42"  ->  42
//    s = "-042"  ->  -42
//    s = "1337c0d3"  ->  1337
//
//  Constraints
//    0 <= s.Length <= 200
//    s may contain letters, digits, spaces, and the characters + - .
//    only SPACES are skipped, and only at the front
//    out-of-range values clamp rather than wrap
//
//  Hints (read only as many as you need)
//    1. Four phases in a fixed order: skip spaces, read at most one sign,
//       read digits, stop. Never go back a phase.
//    2. The digits must stop at the first non-digit rather than skipping over
//       it, which is why "0-1" is 0 and "words and 987" is 0.
//    3. Overflow is the real content. Check BEFORE multiplying: if the
//       running value already exceeds int.MaxValue / 10, or equals it and the
//       next digit would push past the last digit of int.MaxValue, clamp and
//       stop. Accumulating in a long and clamping afterwards also works and
//       is easier to get right.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(8)]
public sealed class StringToInteger : ProblemTests<StringToInteger>
{
    public int Solve(string s)
    {
        throw new NotImplementedException();
    }
}
