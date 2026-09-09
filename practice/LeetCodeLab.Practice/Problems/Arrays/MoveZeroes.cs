namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  283. Move Zeroes                                                     [Easy]
//  https://leetcode.com/problems/move-zeroes/
// ----------------------------------------------------------------------------
//  Move every zero to the end of the array while keeping the non-zero values
//  in their original relative order. Do it in place; the method returns
//  nothing and the array itself is checked.
//
//  Examples
//    nums = [0,1,0,3,12]  ->  nums becomes [1,3,12,0,0]
//    nums = [0]  ->  nums becomes [0]
//    nums = [1,0,1]  ->  nums becomes [1,1,0]
//
//  Constraints
//    1 <= nums.Length <= 10^4
//
//  Hints (read only as many as you need)
//    1. Two cursors: one reading, one marking where the next non-zero should
//       be written.
//    2. First pass, copy every non-zero value to the write cursor and advance
//       it.
//    3. Second pass, fill everything from the write cursor onward with zeros.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(283)]
public sealed class MoveZeroes : ProblemTests<MoveZeroes>
{
    public void Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
