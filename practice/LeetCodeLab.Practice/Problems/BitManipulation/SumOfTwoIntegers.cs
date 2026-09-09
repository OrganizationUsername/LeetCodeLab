namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  371. Sum of Two Integers                                           [Medium]
//  https://leetcode.com/problems/sum-of-two-integers/
// ----------------------------------------------------------------------------
//  Return a + b without using the + or - operators. Negative inputs must
//  work, which is where this stops being a party trick and starts being about
//  two's complement.
//
//  Examples
//    a = 1, b = 2  ->  3
//    a = 2, b = 3  ->  5
//    a = -1, b = 1  ->  0
//
//  Constraints
//    -1000 <= a, b <= 1000
//    the + and - operators are off limits, including inside compound assignment
//
//  Hints (read only as many as you need)
//    1. Split addition into two halves: the part that adds without carrying,
//       and the carry itself.
//    2. XOR is addition ignoring carries. AND finds the positions that
//       generate a carry, and that carry lands one place to the left, so
//       shift it.
//    3. Loop: while the carry is non-zero, take sum = a ^ b and carry = (a &
//       b) << 1, then repeat with those. In C# you must do the shift in
//       unsigned or in a checked-off context, because shifting a negative
//       carry left is where this overflows.
//
//  Aim for O(1) time, O(1) space
// ============================================================================
[Problem(371)]
public sealed class SumOfTwoIntegers : ProblemTests<SumOfTwoIntegers>
{
    public int Solve(int a, int b)
    {
        throw new NotImplementedException();
    }
}
