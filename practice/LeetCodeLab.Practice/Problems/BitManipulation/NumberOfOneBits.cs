namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  191. Number of 1 Bits                                                [Easy]
//  https://leetcode.com/problems/number-of-1-bits/
// ----------------------------------------------------------------------------
//  Return how many bits are set in the binary representation of n, treating
//  it as a 32-bit pattern.
//
//  Examples
//    n = 11  ->  3
//    n = 128  ->  1
//    n = 2147483645  ->  30
//
//  Constraints
//    0 <= n <= 2^31 - 1
//
//  Hints (read only as many as you need)
//    1. Test the lowest bit with n & 1, then shift right. Use an unsigned
//       shift or a uint if you ever handle negatives.
//    2. That loops 32 times regardless of how many bits are set.
//    3. The trick n & (n - 1) clears the lowest set bit, so looping until n
//       is zero runs once per set bit.
//
//  Aim for O(set bits) time
// ============================================================================
[Problem(191)]
public sealed class NumberOfOneBits : ProblemTests<NumberOfOneBits>
{
    public int Solve(int n)
    {
        throw new NotImplementedException();
    }
}
