namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  189. Rotate Array                                                  [Medium]
//  https://leetcode.com/problems/rotate-array/
// ----------------------------------------------------------------------------
//  Rotate the array right by k positions, in place. k may exceed the array
//  length. Nothing is returned; the array itself is checked.
//
//  Examples
//    nums = [1,2,3,4,5,6,7], k = 3  ->  nums becomes [5,6,7,1,2,3,4]
//    nums = [-1,-100,3,99], k = 2  ->  nums becomes [3,99,-1,-100]
//    nums = [1,2], k = 3  ->  nums becomes [2,1]
//
//  Constraints
//    1 <= nums.Length <= 10^5
//    0 <= k <= 10^5
//
//  Hints (read only as many as you need)
//    1. Reduce k modulo the length first, or you will do redundant work.
//    2. Copying into a fresh array at index (i + k) % n is the easy O(n)
//       space answer.
//    3. For O(1) space, reverse the whole array, then reverse the first k
//       elements, then reverse the rest.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(189)]
public sealed class RotateArray : ProblemTests<RotateArray>
{
    public void Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
