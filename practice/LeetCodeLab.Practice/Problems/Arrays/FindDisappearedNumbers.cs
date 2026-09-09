namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  448. Find All Numbers Disappeared in an Array                        [Easy]
//  https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
// ----------------------------------------------------------------------------
//  nums has length n and every value lies between 1 and n. Some values appear
//  twice and some not at all. Return every value in 1..n that is absent, in
//  any order.
//
//  Examples
//    nums = [4,3,2,7,8,2,3,1]  ->  [5,6]
//    nums = [1,1]  ->  [2]
//    nums = [1,2,3]  ->  []
//
//  Constraints
//    1 <= nums.Length <= 10^5
//    1 <= nums[i] <= nums.Length
//
//  Hints (read only as many as you need)
//    1. A HashSet of what is present, then a sweep of 1..n, is the direct
//       solution.
//    2. For O(1) extra space, use the array itself as the marker: value v
//       means index v-1 is present.
//    3. Walk the array negating nums[abs(v)-1]. Afterwards, any index still
//       holding a positive value was never marked.
//
//  Aim for O(n) time, O(1) extra space
// ============================================================================
[Problem(448)]
public sealed class FindDisappearedNumbers : ProblemTests<FindDisappearedNumbers>
{
    public IList<int> Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
