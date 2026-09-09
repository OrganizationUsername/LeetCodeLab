namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  84. Largest Rectangle in Histogram                                   [Hard]
//  https://leetcode.com/problems/largest-rectangle-in-histogram/
// ----------------------------------------------------------------------------
//  Each value is the height of a bar of width one. Return the area of the
//  largest rectangle that fits entirely inside the histogram.
//
//  Examples
//    heights = [2,1,5,6,2,3]  ->  10
//    heights = [2,4]  ->  4
//    heights = [1,1]  ->  2
//
//  Constraints
//    1 <= heights.Length <= 10^5
//    0 <= heights[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. Every maximal rectangle is capped by some bar being its full height.
//       So for each bar, how far left and right can it extend before hitting
//       something shorter?
//    2. A monotonic increasing stack of indices answers that. While the
//       incoming bar is shorter than the stack top, that top bar can extend
//       no further right.
//    3. On popping, the width runs from the new stack top (exclusive) to the
//       current index (exclusive). A sentinel of height 0 at the end flushes
//       the stack.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(84)]
public sealed class LargestRectangleInHistogram : ProblemTests<LargestRectangleInHistogram>
{
    public int Solve(int[] heights)
    {
        throw new NotImplementedException();
    }
}
