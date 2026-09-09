namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  137. Single Number II                                              [Medium]
//  https://leetcode.com/problems/single-number-ii/
// ----------------------------------------------------------------------------
//  Every value appears exactly three times except one, which appears once.
//  Return that one. Use constant extra space, so counting in a dictionary
//  does not qualify.
//
//  Examples
//    nums = [2,2,3,2]  ->  3
//    nums = [0,1,0,1,0,1,99]  ->  99
//    nums = [1]  ->  1
//
//  Constraints
//    1 <= nums.Length <= 3*10^4
//    -2^31 <= nums[i] <= 2^31 - 1
//    every value but one appears exactly three times
//    O(1) extra space and linear time
//
//  Hints (read only as many as you need)
//    1. XOR solved the appears-twice version because XOR cancels pairs. Three
//       of a kind does not cancel under XOR, so you need a counter that wraps
//       at three rather than at two.
//    2. Work one bit position at a time: count how many of the 32 positions
//       hold a 1 across all numbers, and take that count modulo 3. What
//       survives is the lone number's bit.
//    3. That gives a clean O(32n) solution. The slicker version keeps two
//       masks, ones and twos, updating them so each bit cycles through 1, 2,
//       0 as it is seen again - but be careful reconstructing a negative
//       answer if you go the per-bit route, since bit 31 is the sign.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(137)]
public sealed class SingleNumberII : ProblemTests<SingleNumberII>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
