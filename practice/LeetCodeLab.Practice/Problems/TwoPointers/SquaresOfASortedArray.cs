namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  977. Squares of a Sorted Array                                       [Easy]
//  https://leetcode.com/problems/squares-of-a-sorted-array/
// ----------------------------------------------------------------------------
//  The input is sorted ascending but may contain negatives. Return the
//  squares of its values, sorted ascending. Aim for linear time.
//
//  Examples
//    nums = [-4,-1,0,3,10]  ->  [0,1,9,16,100]
//    nums = [-7,-3,2,3,11]  ->  [4,9,9,49,121]
//    nums = [-5,-3,-2,-1]  ->  [1,4,9,25]
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    nums is sorted ascending
//
//  Hints (read only as many as you need)
//    1. Squaring and sorting is O(n log n) and correct. The point is to beat
//       it.
//    2. The largest square is always at one END of the array, since negatives
//       grow when squared.
//    3. Two pointers from both ends, writing into the result from the BACK
//       forwards.
//
//  Aim for O(n) time
// ============================================================================
[Problem(977)]
public sealed class SquaresOfASortedArray : ProblemTests<SquaresOfASortedArray>
{
    public int[] Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
