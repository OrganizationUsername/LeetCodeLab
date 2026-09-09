namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  566. Reshape the Matrix                                              [Easy]
//  https://leetcode.com/problems/reshape-the-matrix/
// ----------------------------------------------------------------------------
//  Refill the values of mat, read row by row, into a new matrix with r rows
//  and c columns. If the new shape cannot hold exactly the same number of
//  values, return the original matrix unchanged.
//
//  Examples
//    mat = [[1,2],[3,4]], r = 1, c = 4  ->  [[1,2,3,4]]
//    mat = [[1,2],[3,4]], r = 4, c = 1  ->  [[1],[2],[3],[4]]
//    mat = [[1,2],[3,4]], r = 2, c = 4  ->  [[1,2],[3,4]]
//
//  Constraints
//    1 <= rows, cols <= 100
//    1 <= r, c <= 300
//    return mat itself when rows*cols != r*c
//
//  Hints (read only as many as you need)
//    1. Check feasibility first: the reshape is possible exactly when
//       rows*cols == r*c. Everything else is index arithmetic.
//    2. Give every cell a running position k from 0 upward. In the source
//       that position is row k/cols, column k%cols; in the destination it is
//       row k/c, column k%c.
//    3. That one identity replaces any attempt to track two pairs of counters
//       by hand, and it is the same trick behind Convert 1D Array Into 2D
//       Array.
//
//  Aim for O(rows*cols) time and space
// ============================================================================
[Problem(566)]
public sealed class ReshapeTheMatrix : ProblemTests<ReshapeTheMatrix>
{
    public int[][] Solve(int[][] mat, int r, int c)
    {
        throw new NotImplementedException();
    }
}
