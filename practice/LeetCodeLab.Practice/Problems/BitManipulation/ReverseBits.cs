namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  190. Reverse Bits                                                    [Easy]
//  https://leetcode.com/problems/reverse-bits/
// ----------------------------------------------------------------------------
//  Reverse the order of the 32 bits of an unsigned integer, so bit 0 becomes
//  bit 31 and vice versa. All 32 bits count, including leading zeros.
//
//  Examples
//    n = 43261596  ->  964176192
//    n = 4294967293  ->  3221225471
//    n = 0  ->  0
//
//  Constraints
//    the input is exactly 32 bits wide
//    leading zeros are significant: reversing them is what moves the low bits up
//
//  Hints (read only as many as you need)
//    1. Build the answer one bit at a time. Pull the lowest bit off the input
//       and push it onto the bottom of a result you keep shifting left.
//    2. Thirty-two iterations, each doing result = (result << 1) | (n & 1)
//       then n >>= 1. Run the loop a fixed 32 times rather than until n is
//       zero, or a small input loses its leading zeros.
//    3. There is a divide-and-conquer version that swaps halves, then
//       quarters, then bytes, then pairs, then single bits, using masks like
//       0xFFFF0000. It is O(log 32) instead of O(32) and is what an
//       interviewer means by 'can you do better'.
//
//  Aim for O(1) time, O(1) space
// ============================================================================
[Problem(190)]
public sealed class ReverseBits : ProblemTests<ReverseBits>
{
    public uint Solve(uint n)
    {
        throw new NotImplementedException();
    }
}
