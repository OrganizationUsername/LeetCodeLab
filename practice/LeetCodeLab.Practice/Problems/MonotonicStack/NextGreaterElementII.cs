namespace LeetCodeLab.Practice.Problems.MonotonicStack;

// ============================================================================
//  503. Next Greater Element II                                       [Medium]
//  https://leetcode.com/problems/next-greater-element-ii/
// ----------------------------------------------------------------------------
//  The array is circular, so searching past the last element continues at the
//  first. For every position return the first strictly greater value found by
//  moving right in that circular order, or -1 if the whole way round never
//  beats it. Duplicates are allowed here.
//
//  Examples
//    nums = [1,2,1]  ->  [2,-1,2]
//    nums = [1,2,3,4,3]  ->  [2,3,4,-1,4]
//    nums = [5,4,3,2,1]  ->  [-1,-1,-1,-1,-1]
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    -10^9 <= nums[i] <= 10^9
//
//  Hints (read only as many as you need)
//    1. Only the wrap-around is new. If the array were laid out twice end to
//       end, no wrap would be needed.
//    2. You do not have to build that doubled array. Iterate the index i from
//       0 to 2n-1 and use i % n.
//    3. Same decreasing stack of indices as the linear version, but push only
//       while i < n; the second lap exists purely to resolve indices still
//       sitting on the stack.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(503)]
public sealed class NextGreaterElementII : ProblemTests<NextGreaterElementII>
{
    public int[] Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
