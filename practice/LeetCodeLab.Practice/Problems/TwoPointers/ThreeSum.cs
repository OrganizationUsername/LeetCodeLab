namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  15. 3Sum                                                           [Medium]
//  https://leetcode.com/problems/3sum/
// ----------------------------------------------------------------------------
//  Return every distinct triple of values from nums that sums to zero. No
//  triple may repeat, though a value can appear twice in a triple if it
//  appears twice in the input. Order of triples, and of values within a
//  triple, does not matter.
//
//  Examples
//    nums = [-1,0,1,2,-1,-4]  ->  [[-1,-1,2],[-1,0,1]]
//    nums = [0,1,1]  ->  []
//    nums = [0,0,0]  ->  [[0,0,0]]
//
//  Constraints
//    3 <= nums.Length <= 3000
//    -10^5 <= nums[i] <= 10^5
//
//  Hints (read only as many as you need)
//    1. Sort first. Sorting makes duplicates adjacent and enables two-pointer
//       scanning.
//    2. Fix the first value, then the rest is Two Sum on a sorted array: a
//       pointer from each end moving inward.
//    3. Skip over equal neighbours at every level, otherwise you emit the
//       same triple repeatedly.
//
//  Aim for O(n^2) time
// ============================================================================
[Problem(15)]
public sealed class ThreeSum : ProblemTests<ThreeSum>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
