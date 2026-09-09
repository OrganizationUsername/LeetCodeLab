namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  55. Jump Game                                                      [Medium]
//  https://leetcode.com/problems/jump-game/
// ----------------------------------------------------------------------------
//  Each nums[i] is the maximum number of steps you may jump forward from
//  index i. Starting at index 0, return whether you can reach the last index.
//
//  Examples
//    nums = [2,3,1,1,4]  ->  true
//    nums = [3,2,1,0,4]  ->  false
//    nums = [0]  ->  true
//
//  Constraints
//    1 <= nums.Length <= 10^4 on the examples, 200000 on the stress case
//    0 <= nums[i] <= 10^5
//
//  Hints (read only as many as you need)
//    1. The quadratic DP that asks is index j reachable for every pair will
//       not survive the stress case.
//    2. Sweep once, holding the furthest index reachable so far.
//    3. If you ever stand on an index beyond that reach, you are stuck and
//       the answer is false. Otherwise extend the reach to max(reach, i +
//       nums[i]).
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(55)]
public sealed class JumpGame : ProblemTests<JumpGame>
{
    public bool Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
