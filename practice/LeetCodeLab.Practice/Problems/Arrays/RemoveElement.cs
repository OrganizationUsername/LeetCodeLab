namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  27. Remove Element                                                   [Easy]
//  https://leetcode.com/problems/remove-element/
// ----------------------------------------------------------------------------
//  Remove every occurrence of val from nums in place and return the count k
//  of values that remain. Only the first k slots are checked, and their order
//  does not matter.
//
//  Examples
//    nums = [3,2,2,3], val = 3  ->  2, with the first 2 entries [2,2]
//    nums = [0,1,2,2,3,0,4,2], val = 2  ->  5, with the first 5 entries [0,1,3,0,4]
//    nums = [], val = 1  ->  0, with the first 0 entries []
//
//  Constraints
//    0 <= nums.Length <= 100
//    0 <= nums[i], val <= 100
//
//  Hints (read only as many as you need)
//    1. Same shape as Remove Duplicates: a read cursor and a write cursor.
//    2. Copy every element that is not val to the write cursor and advance
//       it.
//    3. The write cursor ends up holding exactly the count you return.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(27)]
public sealed class RemoveElement : ProblemTests<RemoveElement>
{
    public int Solve(int[] nums, int val)
    {
        throw new NotImplementedException();
    }
}
