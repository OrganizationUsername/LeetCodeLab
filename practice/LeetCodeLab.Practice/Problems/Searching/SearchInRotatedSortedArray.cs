namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  33. Search in Rotated Sorted Array                                 [Medium]
//  https://leetcode.com/problems/search-in-rotated-sorted-array/
// ----------------------------------------------------------------------------
//  A sorted array of distinct values was rotated at some unknown pivot.
//  Return the index of target, or -1. Must run in logarithmic time.
//
//  Examples
//    nums = [4,5,6,7,0,1,2], target = 0  ->  4
//    nums = [4,5,6,7,0,1,2], target = 3  ->  -1
//    nums = [1], target = 0  ->  -1
//
//  Constraints
//    1 <= nums.Length <= 5000
//    all values distinct
//
//  Hints (read only as many as you need)
//    1. Even after rotation, at least one half of any subrange is still
//       sorted.
//    2. Compare nums[lo] with nums[mid] to work out which half is the sorted
//       one.
//    3. If target lies inside that sorted half range, search there; otherwise
//       search the other half.
//
//  Aim for O(log n) time
// ============================================================================
[Problem(33)]
public sealed class SearchInRotatedSortedArray : ProblemTests<SearchInRotatedSortedArray>
{
    public int Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
