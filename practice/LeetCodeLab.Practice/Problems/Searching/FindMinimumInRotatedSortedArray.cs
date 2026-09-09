namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  153. Find Minimum in Rotated Sorted Array                          [Medium]
//  https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
// ----------------------------------------------------------------------------
//  A sorted array of distinct values was rotated at an unknown pivot. Return
//  its minimum element in logarithmic time.
//
//  Examples
//    nums = [3,4,5,1,2]  ->  1
//    nums = [4,5,6,7,0,1,2]  ->  0
//    nums = [11,13,15,17]  ->  11
//
//  Constraints
//    1 <= nums.Length <= 5000
//    all values distinct
//
//  Hints (read only as many as you need)
//    1. The minimum is the single point where the array stops increasing.
//    2. Compare nums[mid] against nums[hi], not nums[lo]. That comparison is
//       unambiguous.
//    3. If nums[mid] > nums[hi] the minimum is strictly right of mid, so lo =
//       mid + 1. Otherwise mid could itself be the minimum, so hi = mid.
//
//  Aim for O(log n) time
// ============================================================================
[Problem(153)]
public sealed class FindMinimumInRotatedSortedArray : ProblemTests<FindMinimumInRotatedSortedArray>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
