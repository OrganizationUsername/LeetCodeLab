namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  90. Subsets II                                                     [Medium]
//  https://leetcode.com/problems/subsets-ii/
// ----------------------------------------------------------------------------
//  Like Subsets, but nums may contain duplicates, and the returned collection
//  must not contain duplicate subsets. Any order, inside and out.
//
//  Examples
//    nums = [1,2,2]  ->  [[],[1],[1,2],[1,2,2],[2],[2,2]]
//    nums = [0]  ->  [[],[0]]
//    nums = [1,1]  ->  [[],[1],[1,1]]
//
//  Constraints
//    1 <= nums.Length <= 10
//    -10 <= nums[i] <= 10
//
//  Hints (read only as many as you need)
//    1. Sort first so equal values sit next to each other.
//    2. Do the usual take-or-skip recursion over indices.
//    3. At a given recursion depth, once you have tried a value, skip past
//       every further copy of it. That single guard removes exactly the
//       duplicate subsets.
//
//  Aim for O(n * 2^n) time
// ============================================================================
[Problem(90)]
public sealed class SubsetsII : ProblemTests<SubsetsII>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
