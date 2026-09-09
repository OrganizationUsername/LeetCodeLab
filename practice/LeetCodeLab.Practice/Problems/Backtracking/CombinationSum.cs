namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  39. Combination Sum                                                [Medium]
//  https://leetcode.com/problems/combination-sum/
// ----------------------------------------------------------------------------
//  The candidates are distinct and each may be reused as many times as you
//  like. Return every distinct combination summing to target. Order of
//  combinations, and of numbers within a combination, does not matter.
//
//  Examples
//    candidates = [2,3,6,7], target = 7  ->  [[2,2,3],[7]]
//    candidates = [2,3,5], target = 8  ->  [[2,2,2,2],[2,3,3],[3,5]]
//    candidates = [2], target = 1  ->  []
//
//  Constraints
//    1 <= candidates.Length <= 30
//    2 <= candidates[i] <= 40
//    1 <= target <= 40
//
//  Hints (read only as many as you need)
//    1. Standard backtracking: choose a candidate, subtract it from the
//       remaining target, recurse, then undo the choice.
//    2. Reuse is allowed, so after choosing index i the next call may start
//       at i again, not i+1.
//    3. Never letting the next call start before i is what prevents the same
//       combination appearing in different orders.
//
//  Aim for exponential in the worst case, which is expected here
// ============================================================================
[Problem(39)]
public sealed class CombinationSum : ProblemTests<CombinationSum>
{
    public IList<IList<int>> Solve(int[] candidates, int target)
    {
        throw new NotImplementedException();
    }
}
