namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  704. Binary Search                                                   [Easy]
//  https://leetcode.com/problems/binary-search/
// ----------------------------------------------------------------------------
//  Plain binary search on a sorted ascending array of distinct values. Return
//  the index of target, or -1.
//
//  Examples
//    nums = [-1,0,3,5,9,12], target = 9  ->  4
//    nums = [-1,0,3,5,9,12], target = 2  ->  -1
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    sorted ascending, all distinct
//
//  Hints (read only as many as you need)
//    1. Two inclusive bounds, lo and hi, and loop while lo <= hi.
//    2. Compute mid as lo + (hi - lo) / 2 rather than (lo + hi) / 2 to avoid
//       overflow.
//    3. Narrow to mid + 1 or mid - 1, never to mid, or the loop will not
//       terminate.
//
//  Aim for O(log n) time, O(1) space
// ============================================================================
[Problem(704)]
public sealed class BinarySearch : ProblemTests<BinarySearch>
{
    public int Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
