namespace LeetCodeLab.Practice.Problems.Numbers;

// ============================================================================
//  7. Reverse Integer                                                 [Medium]
//  https://leetcode.com/problems/reverse-integer/
// ----------------------------------------------------------------------------
//  Reverse the digits of a signed 32-bit integer, keeping the sign. If the
//  reversed value falls outside the signed 32-bit range, return 0 instead.
//  You may not use a 64-bit type to dodge the check.
//
//  Examples
//    x = 123  ->  321
//    x = -123  ->  -321
//    x = 120  ->  21
//
//  Constraints
//    -2^31 <= x <= 2^31 - 1
//
//  Hints (read only as many as you need)
//    1. Peel digits with % 10 and / 10. In C# these already behave correctly
//       for negatives, so the sign takes care of itself.
//    2. The trap is detecting overflow BEFORE it happens.
//    3. Before doing result = result * 10 + digit, check whether result
//       already exceeds int.MaxValue / 10, and handle the boundary digit
//       case.
//
//  Aim for O(number of digits) time
// ============================================================================
[Problem(7)]
public sealed class ReverseInteger : ProblemTests<ReverseInteger>
{
    public int Solve(int x)
    {
        throw new NotImplementedException();
    }
}
