namespace LeetCodeLab.Practice.Problems.Numbers;

// ============================================================================
//  9. Palindrome Number                                                 [Easy]
//  https://leetcode.com/problems/palindrome-number/
// ----------------------------------------------------------------------------
//  Return true when the integer reads the same forwards and backwards.
//  Negative numbers are never palindromes because of the minus sign. Try it
//  without converting to a string.
//
//  Examples
//    x = 121  ->  true
//    x = -121  ->  false
//    x = 10  ->  false
//
//  Constraints
//    -2^31 <= x <= 2^31 - 1
//
//  Hints (read only as many as you need)
//    1. Negatives are false immediately, as is any positive multiple of 10
//       other than 0.
//    2. Repeatedly peel the last digit with % 10 and / 10 to build a reversed
//       number.
//    3. To dodge overflow entirely, only reverse HALF the digits and stop
//       when the reversed half reaches or passes the remaining half.
//
//  Aim for O(number of digits) time, O(1) space
// ============================================================================
[Problem(9)]
public sealed class PalindromeNumber : ProblemTests<PalindromeNumber>
{
    public bool Solve(int x)
    {
        throw new NotImplementedException();
    }
}
