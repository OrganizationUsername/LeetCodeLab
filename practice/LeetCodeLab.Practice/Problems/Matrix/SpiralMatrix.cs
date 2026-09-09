namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  54. Spiral Matrix                                                  [Medium]
//  https://leetcode.com/problems/spiral-matrix/
// ----------------------------------------------------------------------------
//  Return all values of the matrix read in spiral order: left to right along
//  the top, down the right side, right to left along the bottom, up the left
//  side, then inward.
//
//  Examples
//    matrix = [[1,2,3],[4,5,6],[7,8,9]]  ->  [1,2,3,6,9,8,7,4,5]
//    matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]  ->  [1,2,3,4,8,12,11,10,9,5,6,7]
//    matrix = [[7],[9],[6]]  ->  [7,9,6]
//
//  Constraints
//    1 <= rows, cols <= 10
//
//  Hints (read only as many as you need)
//    1. Hold four boundaries: top, bottom, left and right.
//    2. Walk one edge at a time and shrink the corresponding boundary
//       afterwards.
//    3. The trap is a non-square matrix, where you can exhaust the rows
//       before the columns. Re-check that the boundaries have not crossed
//       before the bottom edge and the left edge.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(54)]
public sealed class SpiralMatrix : ProblemTests<SpiralMatrix>
{
    public IList<int> Solve(int[][] matrix)
    {
        throw new NotImplementedException();
    }
}
