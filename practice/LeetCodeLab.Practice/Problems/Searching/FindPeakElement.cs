using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  162. Find Peak Element                                             [Medium]
//  https://leetcode.com/problems/find-peak-element/
// ----------------------------------------------------------------------------
//  A peak is any element strictly greater than both its neighbours, with
//  positions outside the array treated as negative infinity. Return the index
//  of ANY peak. Several may exist and any is accepted. Must run in
//  logarithmic time.
//
//  Examples
//    nums = [1,2,3,1]  ->  2  (other answers may also be accepted)
//    nums = [1,2,1,3,5,6,4]  ->  5  (other answers may also be accepted)
//    nums = [1]  ->  0  (other answers may also be accepted)
//
//  Constraints
//    1 <= nums.Length <= 1000
//    neighbouring values are never equal
//
//  Hints (read only as many as you need)
//    1. Logarithmic time on an unsorted array sounds impossible, but you are
//       not searching for a specific value.
//    2. Look at the middle element and its right neighbour. If the slope is
//       going up, a peak must exist somewhere to the right; if down, one
//       exists at mid or to its left.
//    3. That is enough to halve the range every step, because the array
//       boundaries act as negative infinity and guarantee a peak in whichever
//       half you keep.
//
//  Aim for O(log n) time
// ============================================================================
[Problem(162)]
public sealed class FindPeakElement : ProblemTests<FindPeakElement>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }

    /// <summary>Harness plumbing: any index that beats both neighbours is accepted.</summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int[] nums = (int[])args[0]!;
        if (actual is not int i || i < 0 || i >= nums.Length) return false;
        return (i == 0 || nums[i] > nums[i - 1])
            && (i == nums.Length - 1 || nums[i] > nums[i + 1]);
    }
}
