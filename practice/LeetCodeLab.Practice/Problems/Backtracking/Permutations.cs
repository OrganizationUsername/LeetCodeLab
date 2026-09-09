namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  46. Permutations                                                   [Medium]
//  https://leetcode.com/problems/permutations/
// ----------------------------------------------------------------------------
//  The values are distinct. Return every possible ordering of them. The list
//  of permutations may be in any order, but each permutation is a specific
//  sequence and its internal order matters.
//
//  Examples
//    nums = [1,2,3]  ->  [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3...
//    nums = [0,1]  ->  [[0,1],[1,0]]
//    nums = [1]  ->  [[1]]
//
//  Constraints
//    1 <= nums.Length <= 6
//    all values distinct
//
//  Hints (read only as many as you need)
//    1. Build the permutation one position at a time.
//    2. Track which indices are already used with a bool array, and try every
//       unused value at each position.
//    3. When the working list reaches full length, copy it into the results.
//       Copy it, do not add the list you keep mutating.
//
//  Aim for O(n * n!) time
// ============================================================================
[Problem(46)]
public sealed class Permutations : ProblemTests<Permutations>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
