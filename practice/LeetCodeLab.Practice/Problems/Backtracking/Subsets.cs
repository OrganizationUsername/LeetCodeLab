namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  78. Subsets                                                        [Medium]
//  https://leetcode.com/problems/subsets/
// ----------------------------------------------------------------------------
//  The values are distinct. Return every subset, including the empty one and
//  the whole array. Any order, and any order within a subset.
//
//  Examples
//    nums = [1,2,3]  ->  [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
//    nums = [0]  ->  [[],[0]]
//
//  Constraints
//    1 <= nums.Length <= 10
//    all values distinct
//
//  Hints (read only as many as you need)
//    1. There are exactly 2^n subsets, since each element is independently in
//       or out.
//    2. Backtracking: at each index, recurse once having taken the element
//       and once having skipped it.
//    3. Alternatively iterate a bitmask from 0 to 2^n - 1 and read off the
//       set bits. No recursion at all.
//
//  Aim for O(n * 2^n) time
// ============================================================================
[Problem(78)]
public sealed class Subsets : ProblemTests<Subsets>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
