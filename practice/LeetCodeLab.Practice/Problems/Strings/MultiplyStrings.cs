namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  43. Multiply Strings                                               [Medium]
//  https://leetcode.com/problems/multiply-strings/
// ----------------------------------------------------------------------------
//  Multiply two non-negative integers given as strings and return the product
//  as a string. The numbers can be far longer than any built-in integer type,
//  so you must do the arithmetic yourself rather than converting.
//
//  Examples
//    num1 = "2", num2 = "3"  ->  "6"
//    num1 = "123", num2 = "456"  ->  "56088"
//    num1 = "0", num2 = "52"  ->  "0"
//
//  Constraints
//    1 <= num1.Length, num2.Length <= 200
//    both are digit strings with no leading zeros, except "0" itself
//    converting to a built-in integer type is not allowed and would overflow anyway
//    the result must have no leading zeros
//
//  Hints (read only as many as you need)
//    1. Long multiplication on paper: every digit of one number times every
//       digit of the other, each landing in a known column.
//    2. Digit i of num1 times digit j of num2 contributes to positions i+j
//       and i+j+1 of the result, counting from the left. An array of
//       num1.Length + num2.Length digits always has room.
//    3. Accumulate all the products first, then do one carry pass over the
//       array from the right. Finally strip leading zeros - and remember the
//       all-zero product must come back as "0", not "".
//
//  Aim for O(n*m) time
// ============================================================================
[Problem(43)]
public sealed class MultiplyStrings : ProblemTests<MultiplyStrings>
{
    public string Solve(string num1, string num2)
    {
        throw new NotImplementedException();
    }
}
