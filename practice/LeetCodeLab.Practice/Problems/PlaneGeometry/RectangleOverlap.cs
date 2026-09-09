namespace LeetCodeLab.Practice.Problems.PlaneGeometry;

// ============================================================================
//  836. Rectangle Overlap                                               [Easy]
//  https://leetcode.com/problems/rectangle-overlap/
// ----------------------------------------------------------------------------
//  Each rectangle is given as [x1, y1, x2, y2] with (x1, y1) the bottom-left
//  corner and (x2, y2) the top-right. Return whether the two overlap in a
//  region of positive area. Touching along an edge or at a corner is not an
//  overlap.
//
//  Examples
//    rec1 = [0,0,2,2], rec2 = [1,1,3,3]  ->  true
//    rec1 = [0,0,1,1], rec2 = [1,0,2,1]  ->  false
//    rec1 = [0,0,1,1], rec2 = [2,2,3,3]  ->  false
//
//  Constraints
//    each rectangle has x1 < x2 and y1 < y2
//    -10^9 <= all coordinates <= 10^9
//
//  Hints (read only as many as you need)
//    1. Enumerating the ways two rectangles can overlap gives a long,
//       bug-prone case analysis. Look for the shorter question instead.
//    2. The x extents are just two intervals, and so are the y extents.
//       Overlap in 2D happens exactly when both pairs of intervals overlap.
//    3. Two intervals [a1,a2] and [b1,b2] overlap with positive length when
//       max(a1,b1) < min(a2,b2). Apply it twice and combine with AND.
//
//  Aim for O(1) time and space
// ============================================================================
[Problem(836)]
public sealed class RectangleOverlap : ProblemTests<RectangleOverlap>
{
    public bool Solve(int[] rec1, int[] rec2)
    {
        throw new NotImplementedException();
    }
}
