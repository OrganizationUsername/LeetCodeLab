namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  91. Decode Ways                                                    [Medium]
//  https://leetcode.com/problems/decode-ways/
// ----------------------------------------------------------------------------
//  A maps to 1 through Z maps to 26. Given a string of digits, count how many
//  ways it can be decoded back into letters. A leading zero is never valid,
//  so 06 does not decode as 6.
//
//  Examples
//    s = "12"  ->  2
//    s = "226"  ->  3
//    s = "06"  ->  0
//
//  Constraints
//    1 <= s.Length <= 100
//    s contains only digits
//
//  Hints (read only as many as you need)
//    1. Same shape as Climbing Stairs, but each step has to be legal.
//    2. ways[i] counts decodings of the first i characters. You extend by one
//       digit when it is not 0, and by two digits when they form 10 to 26.
//    3. ways[i] = (single digit valid ? ways[i-1] : 0) + (pair valid ?
//       ways[i-2] : 0). A string starting with 0 has zero decodings.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(91)]
public sealed class DecodeWays : ProblemTests<DecodeWays>
{
    public int Solve(string s)
    {
        throw new NotImplementedException();
    }
}
