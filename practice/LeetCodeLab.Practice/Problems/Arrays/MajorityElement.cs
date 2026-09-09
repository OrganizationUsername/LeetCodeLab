namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  169. Majority Element                                                [Easy]
//  https://leetcode.com/problems/majority-element/
// ----------------------------------------------------------------------------
//  One value occupies more than half the array. Return it. You may assume it
//  always exists.
//
//  Examples
//    nums = [3,2,3]  ->  3
//    nums = [2,2,1,1,1,2,2]  ->  2
//    nums = [1]  ->  1
//
//  Constraints
//    1 <= nums.Length <= 5*10^4
//    the majority element always exists
//
//  Hints (read only as many as you need)
//    1. Counting occurrences in a Dictionary works and is O(n) space.
//    2. Sorting also works: the majority element must occupy the middle
//       position.
//    3. For O(1) space use the Boyer-Moore vote: hold a candidate and a
//       count, increment on a match, decrement otherwise, and swap candidate
//       when the count hits zero.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(169)]
public sealed class MajorityElement : ProblemTests<MajorityElement>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
