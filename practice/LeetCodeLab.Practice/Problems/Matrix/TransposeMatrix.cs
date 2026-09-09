namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  867. Transpose Matrix                                                [Easy]
//  https://leetcode.com/problems/transpose-matrix/
// ----------------------------------------------------------------------------
//  Return the transpose: the matrix flipped over its main diagonal, so row i
//  column j of the answer is row j column i of the input. The matrix need not
//  be square, so the result may have different dimensions from the input.
//
//  Examples
//    matrix = [[1,2,3],[4,5,6],[7,8,9]]  ->  [[1,4,7],[2,5,8],[3,6,9]]
//    matrix = [[1,2,3],[4,5,6]]  ->  [[1,4],[2,5],[3,6]]
//    matrix = [[1,2],[3,4],[5,6]]  ->  [[1,3,5],[2,4,6]]
//
//  Constraints
//    1 <= rows, cols <= 1000
//    the input is rectangular: every row has the same length
//
//  Hints (read only as many as you need)
//    1. The answer has cols rows and rows columns. Allocate it that way round
//       before you write anything into it.
//    2. This is why Rotate Image can transpose in place and this cannot: a
//       non-square transpose does not fit back into the original array.
//    3. One double loop, result[j][i] = matrix[i][j]. The whole difficulty is
//       not muddling the two extents.
//
//  Aim for O(rows*cols) time and space
// ============================================================================
[Problem(867)]
public sealed class TransposeMatrix : ProblemTests<TransposeMatrix>
{
    public int[][] Solve(int[][] matrix)
    {
        throw new NotImplementedException();
    }
}
