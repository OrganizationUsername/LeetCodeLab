namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  347. Top K Frequent Elements                                       [Medium]
//  https://leetcode.com/problems/top-k-frequent-elements/
// ----------------------------------------------------------------------------
//  Return the k values that occur most often, in any order. The answer is
//  guaranteed unique.
//
//  Examples
//    nums = [1,1,1,2,2,3], k = 2  ->  [1,2]
//    nums = [1], k = 1  ->  [1]
//    nums = [4,4,4,5,5,6], k = 2  ->  [4,5]
//
//  Constraints
//    1 <= nums.Length <= 10^5
//    k is between 1 and the number of distinct values
//
//  Hints (read only as many as you need)
//    1. Start with a Dictionary of value to occurrence count.
//    2. Then you need the k largest counts. Sorting the distinct values by
//       count is acceptable.
//    3. For linear time: bucket by count, since no count can exceed
//       nums.Length, then read buckets from the top down.
//
//  Aim for O(n log n) with sorting, O(n) with bucketing
// ============================================================================
[Problem(347)]
public sealed class TopKFrequentElements : ProblemTests<TopKFrequentElements>
{
    public int[] Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
