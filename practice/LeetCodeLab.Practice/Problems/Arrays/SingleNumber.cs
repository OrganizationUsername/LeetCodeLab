namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  136. Single Number                                                   [Easy]
//  https://leetcode.com/problems/single-number/
// ----------------------------------------------------------------------------
//  Every value appears exactly twice except one, which appears once. Return
//  that one. Use linear time and constant extra space.
//
//  Examples
//    nums = [2,2,1]  ->  1
//    nums = [4,1,2,1,2]  ->  4
//    nums = [1]  ->  1
//
//  Constraints
//    1 <= nums.Length <= 3*10^4
//    every element appears twice except one
//
//  Hints (read only as many as you need)
//    1. A HashSet solves it but costs O(n) space, which the problem forbids.
//    2. You need an operation where combining a value with itself cancels
//       out.
//    3. XOR does exactly that: x ^ x is 0 and x ^ 0 is x. XOR the whole array
//       together.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(136)]
public sealed class SingleNumber : ProblemTests<SingleNumber>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
