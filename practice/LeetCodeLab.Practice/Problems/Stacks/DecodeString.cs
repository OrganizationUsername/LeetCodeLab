namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  394. Decode String                                                 [Medium]
//  https://leetcode.com/problems/decode-string/
// ----------------------------------------------------------------------------
//  The encoding k[encoded] means the enclosed text repeated k times, and
//  encodings may nest. Expand the whole string. The input is always well
//  formed and the repeat counts are always positive integers.
//
//  Examples
//    s = "3[a]2[bc]"  ->  "aaabcbc"
//    s = "3[a2[c]]"  ->  "accaccacc"
//    s = "2[abc]3[cd]ef"  ->  "abcabccdcdcdef"
//
//  Constraints
//    1 <= s.Length <= 30
//    the input is always valid, with balanced brackets
//    repeat counts may be more than one digit
//    the decoded result fits comfortably in memory
//
//  Hints (read only as many as you need)
//    1. The nesting is what makes this more than string replacement: an inner
//       group must be expanded before the outer one can repeat it.
//    2. Two stacks, one for the partly-built text and one for the pending
//       repeat counts. An opening bracket pushes both and starts a fresh
//       buffer.
//    3. The closing bracket is where the work happens: pop the count and the
//       outer buffer, then append the current buffer to it that many times.
//       Read multi-digit numbers fully before the bracket, or 10[a] becomes 1
//       then 0.
//
//  Aim for O(length of the decoded output) time
// ============================================================================
[Problem(394)]
public sealed class DecodeString : ProblemTests<DecodeString>
{
    public string Solve(string s)
    {
        throw new NotImplementedException();
    }
}
