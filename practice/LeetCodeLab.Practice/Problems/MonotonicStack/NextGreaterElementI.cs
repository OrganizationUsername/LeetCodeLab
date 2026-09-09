namespace LeetCodeLab.Practice.Problems.MonotonicStack;

// ============================================================================
//  496. Next Greater Element I                                          [Easy]
//  https://leetcode.com/problems/next-greater-element-i/
// ----------------------------------------------------------------------------
//  nums1 is a subset of nums2 and all values are distinct. For each value in
//  nums1, find it in nums2 and report the first value to its right that is
//  larger. Report -1 when there is none. Answer in the order nums1 gives.
//
//  Examples
//    nums1 = [4,1,2], nums2 = [1,3,4,2]  ->  [-1,3,-1]
//    nums1 = [2,4], nums2 = [1,2,3,4]  ->  [3,-1]
//    nums1 = [1,3,5,2,4], nums2 = [6,5,4,3,2,1]  ->  [-1,-1,6,-1,5]
//
//  Constraints
//    1 <= nums1.Length <= nums2.Length <= 1000
//    all values across both arrays are distinct
//    every value of nums1 also appears in nums2
//
//  Hints (read only as many as you need)
//    1. Forget nums1 to begin with. Solve next-greater-to-the-right for every
//       position of nums2 in one pass, then just look the answers up.
//    2. Scan nums2 and keep a stack of values still waiting for their answer.
//       What must be true about that stack from bottom to top?
//    3. Keep it decreasing. A new value x resolves every stacked value
//       smaller than x - pop them and record x as their answer - then push x.
//       Store the answers in a Dictionary keyed by value.
//
//  Aim for O(n + m) time, O(n) space
// ============================================================================
[Problem(496)]
public sealed class NextGreaterElementI : ProblemTests<NextGreaterElementI>
{
    public int[] Solve(int[] nums1, int[] nums2)
    {
        throw new NotImplementedException();
    }
}
