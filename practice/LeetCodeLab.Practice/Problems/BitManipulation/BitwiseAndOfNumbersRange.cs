namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  201. Bitwise AND of Numbers Range                                  [Medium]
//  https://leetcode.com/problems/bitwise-and-of-numbers-range/
// ----------------------------------------------------------------------------
//  Return the bitwise AND of every integer from left to right inclusive. The
//  range can span two billion values, so looping over it is not an option.
//
//  Examples
//    left = 5, right = 7  ->  4
//    left = 0, right = 0  ->  0
//    left = 1, right = 2147483647  ->  0
//
//  Constraints
//    0 <= left <= right <= 2^31 - 1
//    the range may contain billions of values, so the answer must not depend on iterating it
//
//  Hints (read only as many as you need)
//    1. A bit survives the AND only if it is 1 in EVERY number of the range.
//       Ask what makes a bit flip somewhere inside the range.
//    2. If left and right differ anywhere at or below some bit position, that
//       bit takes both values somewhere between them, so it ends up 0. Only
//       the shared leading prefix can survive.
//    3. So the answer is the common binary prefix of left and right, padded
//       with zeros. Shift both right until they are equal, counting the
//       shifts, then shift back. Equivalently, keep clearing the lowest set
//       bit of right until right <= left.
//
//  Aim for O(1) time, O(1) space
// ============================================================================
[Problem(201)]
public sealed class BitwiseAndOfNumbersRange : ProblemTests<BitwiseAndOfNumbersRange>
{
    public int Solve(int left, int right)
    {
        throw new NotImplementedException();
    }
}
