namespace LeetCodeLab.Practice.Problems.MonotonicStack;

// ============================================================================
//  239. Sliding Window Maximum                                          [Hard]
//  https://leetcode.com/problems/sliding-window-maximum/
// ----------------------------------------------------------------------------
//  A window of width k slides one step at a time from the left end of nums to
//  the right. Return the maximum inside the window at each of its n-k+1
//  positions.
//
//  Examples
//    nums = [1,3,-1,-3,5,3,6,7], k = 3  ->  [3,3,5,5,6,7]
//    nums = [1], k = 1  ->  [1]
//    nums = [1,-1], k = 1  ->  [1,-1]
//
//  Constraints
//    1 <= k <= nums.Length <= 10^5
//    -10^4 <= nums[i] <= 10^4
//    rescanning the window at every step is O(nk) and will not pass the stress case
//
//  Hints (read only as many as you need)
//    1. When a new element enters on the right, which of the elements already
//       in the window could still be the answer later?
//    2. Not the ones smaller than the newcomer and to its left: the newcomer
//       outlives them and beats them, so they can be discarded forever.
//    3. Keep a deque of indices whose values decrease from front to back. Pop
//       from the back while the newcomer is larger, push it, then drop the
//       front if it has fallen out of the window. The front is always the
//       maximum.
//
//  Aim for O(n) time, O(k) space
// ============================================================================
[Problem(239)]
public sealed class SlidingWindowMaximum : ProblemTests<SlidingWindowMaximum>
{
    public int[] Solve(int[] nums, int k)
    {
        throw new NotImplementedException();
    }
}
