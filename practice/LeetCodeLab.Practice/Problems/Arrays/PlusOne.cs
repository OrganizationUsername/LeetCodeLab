namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  66. Plus One                                                         [Easy]
//  https://leetcode.com/problems/plus-one/
// ----------------------------------------------------------------------------
//  The array holds the decimal digits of a non-negative integer, most
//  significant first. Add one and return the resulting digits.
//
//  Examples
//    digits = [1,2,3]  ->  [1,2,4]
//    digits = [4,3,2,1]  ->  [4,3,2,2]
//    digits = [9]  ->  [1,0]
//
//  Constraints
//    1 <= digits.Length <= 100
//    no leading zeros except the number 0 itself
//
//  Hints (read only as many as you need)
//    1. Do not convert to an integer; the number can exceed every built-in
//       type.
//    2. Walk from the last digit backwards. A digit below 9 just increments
//       and you are finished.
//    3. A 9 becomes 0 and carries. If you fall off the front still carrying,
//       the answer is one digit longer and starts with 1.
//
//  Aim for O(n) time
// ============================================================================
[Problem(66)]
public sealed class PlusOne : ProblemTests<PlusOne>
{
    public int[] Solve(int[] digits)
    {
        throw new NotImplementedException();
    }
}
