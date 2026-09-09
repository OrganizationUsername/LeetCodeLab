namespace LeetCodeLab.Practice.Problems.Numbers;

// ============================================================================
//  13. Roman to Integer                                                 [Easy]
//  https://leetcode.com/problems/roman-to-integer/
// ----------------------------------------------------------------------------
//  Convert a valid Roman numeral to its integer value. Normally symbols
//  descend in value and you add them, but six subtractive pairs (IV, IX, XL,
//  XC, CD, CM) mean subtract instead.
//
//  Examples
//    s = "III"  ->  3
//    s = "LVIII"  ->  58
//    s = "MCMXCIV"  ->  1994
//
//  Constraints
//    1 <= s.Length <= 15
//    s is a valid Roman numeral in the range 1 to 3999
//
//  Hints (read only as many as you need)
//    1. Map each symbol to its value in a dictionary or switch.
//    2. Walk left to right. A symbol worth LESS than the one after it is
//       being subtracted.
//    3. So add its value normally, but subtract it when the next symbol is
//       larger. The final symbol is always added.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(13)]
public sealed class RomanToInteger : ProblemTests<RomanToInteger>
{
    public int Solve(string s)
    {
        throw new NotImplementedException();
    }
}
