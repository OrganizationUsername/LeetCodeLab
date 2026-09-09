namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  1. Two Sum                                                           [Easy]
//  https://leetcode.com/problems/two-sum/
// ----------------------------------------------------------------------------
//  Find the two entries of nums that add up to target and return their
//  positions. Exactly one pair works, you may not use the same element twice,
//  and either order is accepted.
//
//  Examples
//    nums = [2,7,11,15], target = 9  ->  [0,1]
//    nums = [3,2,4], target = 6  ->  [1,2]
//    nums = [3,3], target = 6  ->  [0,1]
//
//  Constraints
//    2 <= nums.Length <= 10^4
//    -10^9 <= nums[i], target <= 10^9
//    exactly one valid answer exists
//
//  Hints (read only as many as you need)
//    1. The obvious double loop is O(n^2). What is it recomputing?
//    2. While scanning, for each x you want to know whether target - x has
//       already appeared.
//    3. A Dictionary from value to index answers that in O(1). Store as you
//       go, so you never match an element with itself.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(1)]
public sealed class TwoSum : ProblemTests<TwoSum>
{
    public int[] Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
