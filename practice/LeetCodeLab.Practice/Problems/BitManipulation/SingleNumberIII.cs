namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  260. Single Number III                                             [Medium]
//  https://leetcode.com/problems/single-number-iii/
// ----------------------------------------------------------------------------
//  Exactly two values appear once; every other value appears twice. Return
//  the two singles in any order, in linear time and constant extra space.
//
//  Examples
//    nums = [1,2,1,3,2,5]  ->  [3,5]
//    nums = [-1,0]  ->  [-1,0]
//    nums = [0,1,0,2]  ->  [1,2]
//
//  Constraints
//    2 <= nums.Length <= 3*10^4
//    exactly two values appear once, the rest appear twice
//    either order is accepted
//
//  Hints (read only as many as you need)
//    1. XOR everything. The pairs cancel, leaving the XOR of the two answers
//       - which is not either answer, but it is not useless either.
//    2. Any bit set in that combined XOR is a bit where the two answers
//       DIFFER. Pick one such bit and it splits every value into two groups,
//       with one answer in each.
//    3. Take the lowest set bit with x & -x, partition on it, and XOR each
//       group separately. Values that appear twice land in the same group as
//       their twin and cancel, so each group reduces to one answer.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(260)]
public sealed class SingleNumberIII : ProblemTests<SingleNumberIII>
{
    public int[] Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
