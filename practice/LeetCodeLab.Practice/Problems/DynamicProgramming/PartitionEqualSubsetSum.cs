namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  416. Partition Equal Subset Sum                                    [Medium]
//  https://leetcode.com/problems/partition-equal-subset-sum/
// ----------------------------------------------------------------------------
//  Return true when nums can be split into two groups with equal sums.
//
//  Examples
//    nums = [1,5,11,5]  ->  true
//    nums = [1,2,3,5]  ->  false
//    nums = [2,2]  ->  true
//
//  Constraints
//    1 <= nums.Length <= 200
//    1 <= nums[i] <= 100
//
//  Hints (read only as many as you need)
//    1. If the total is odd the answer is immediately false.
//    2. Otherwise the question becomes: can some subset sum to exactly half
//       the total? That is the subset-sum problem.
//    3. Keep a bool array over achievable sums, seeded with 0. For each
//       number, sweep the array DOWNWARD so each number is used at most once.
//
//  Aim for O(n * sum) time
// ============================================================================
[Problem(416)]
public sealed class PartitionEqualSubsetSum : ProblemTests<PartitionEqualSubsetSum>
{
    public bool Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
