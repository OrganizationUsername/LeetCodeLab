namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  35. Search Insert Position                                           [Easy]
//  https://leetcode.com/problems/search-insert-position/
// ----------------------------------------------------------------------------
//  The array is sorted and distinct. Return the index of target, or the index
//  where it would be inserted to keep the array sorted. Logarithmic time.
//
//  Examples
//    nums = [1,3,5,6], target = 5  ->  2
//    nums = [1,3,5,6], target = 2  ->  1
//    nums = [1,3,5,6], target = 7  ->  4
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    sorted ascending, all distinct
//
//  Hints (read only as many as you need)
//    1. This is binary search with a different answer on failure.
//    2. Run the standard loop. If you find the target, return its index.
//    3. When the loop ends without a hit, the low pointer is sitting exactly
//       at the insertion point. That is the answer.
//
//  Aim for O(log n) time
// ============================================================================
[Problem(35)]
public sealed class SearchInsertPosition : ProblemTests<SearchInsertPosition>
{
    public int Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
