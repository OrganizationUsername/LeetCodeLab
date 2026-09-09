namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  59. Spiral Matrix II                                               [Medium]
//  https://leetcode.com/problems/spiral-matrix-ii/
// ----------------------------------------------------------------------------
//  Build an n by n matrix holding 1 to n*n placed in spiral order: left to
//  right along the top, down the right side, right to left along the bottom,
//  up the left side, then inward. This is Spiral Matrix run backwards - you
//  are writing the cells rather than reading them.
//
//  Examples
//    n = 1  ->  [[1]]
//    n = 2  ->  [[1,2],[4,3]]
//    n = 3  ->  [[1,2,3],[8,9,4],[7,6,5]]
//
//  Constraints
//    1 <= n <= 20
//
//  Hints (read only as many as you need)
//    1. The traversal is identical to reading a spiral. Only the body of the
//       loop changes: assign a counter instead of appending to a list.
//    2. Four boundaries again - top, bottom, left, right - each shrinking
//       after the edge it owns has been walked.
//    3. Because the matrix is square you never hit the non-square degenerate
//       case, but an odd n still ends on a single centre cell. Stop on the
//       count reaching n*n rather than trying to detect that separately.
//
//  Aim for O(n^2) time, O(1) extra space
// ============================================================================
[Problem(59)]
public sealed class SpiralMatrixII : ProblemTests<SpiralMatrixII>
{
    public int[][] Solve(int n)
    {
        throw new NotImplementedException();
    }
}
