namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  48. Rotate Image                                                   [Medium]
//  https://leetcode.com/problems/rotate-image/
// ----------------------------------------------------------------------------
//  Rotate the square matrix 90 degrees clockwise, in place. Nothing is
//  returned; the matrix itself is checked.
//
//  Examples
//    matrix = [[1,2,3],[4,5,6],[7,8,9]]  ->  matrix becomes [[7,4,1],[8,5,2],[9,6,3]]
//    matrix = [[1,2],[3,4]]  ->  matrix becomes [[3,1],[4,2]]
//    matrix = [[1]]  ->  matrix becomes [[1]]
//
//  Constraints
//    1 <= n <= 20
//    the matrix is square
//
//  Hints (read only as many as you need)
//    1. Allocating a second matrix is easy but the problem asks for in place.
//    2. A clockwise rotation is the same as transposing (mirroring across the
//       main diagonal) and then reversing each row.
//    3. When transposing, only touch entries above the diagonal, or you swap
//       everything back.
//
//  Aim for O(n^2) time, O(1) space
// ============================================================================
[Problem(48)]
public sealed class RotateImage : ProblemTests<RotateImage>
{
    public void Solve(int[][] matrix)
    {
        var size = matrix.GetLength(0);

        for (var j = 0; j < size; j++)
        {
            for (var i = 0; i + j < size - 1; i++)
            {
                var endX = size - j - 1;
                var endY = size - i - 1;
                (matrix[i][j], matrix[endX][endY]) = (matrix[endX][endY], matrix[i][j]);
            }
        }

        Array.Reverse(matrix);
    }
}
