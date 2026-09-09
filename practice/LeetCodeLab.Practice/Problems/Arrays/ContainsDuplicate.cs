namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  217. Contains Duplicate                                              [Easy]
//  https://leetcode.com/problems/contains-duplicate/
// ----------------------------------------------------------------------------
//  Return true if any value appears at least twice, false if every element is
//  distinct.
//
//  Examples
//    nums = [1,2,3,1]  ->  true
//    nums = [1,2,3,4]  ->  false
//    nums = [1,1,1,3,3,4,3,2,4,2]  ->  true
//
//  Constraints
//    1 <= nums.Length <= 10^5
//    -10^9 <= nums[i] <= 10^9
//
//  Hints (read only as many as you need)
//    1. Comparing every pair is O(n^2) and will time out on the stress case.
//    2. A HashSet gives you have-I-seen-this in O(1).
//    3. You do not even need a loop: a set built from the array has fewer
//       elements than the array exactly when there was a duplicate.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(217)]
public sealed class ContainsDuplicate : ProblemTests<ContainsDuplicate>
{
    public bool Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
