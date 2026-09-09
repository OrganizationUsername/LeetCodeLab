namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  45. Jump Game II                                                   [Medium]
//  https://leetcode.com/problems/jump-game-ii/
// ----------------------------------------------------------------------------
//  Same jumping rule as Jump Game, but the last index is always reachable.
//  Return the minimum number of jumps needed to get there.
//
//  Examples
//    nums = [2,3,1,1,4]  ->  2
//    nums = [2,3,0,1,4]  ->  2
//    nums = [1]  ->  0
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    the last index is always reachable
//
//  Hints (read only as many as you need)
//    1. Think of it as breadth-first search on ranges: jump 1 covers some
//       window of indices, jump 2 covers the next window, and so on.
//    2. Sweep left to right holding the end of the current window and the
//       furthest index any element in it can reach.
//    3. When you arrive at the window end, you must spend a jump, and the new
//       window end becomes that furthest reach.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(45)]
public sealed class JumpGameII : ProblemTests<JumpGameII>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
