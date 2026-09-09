namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  73. Set Matrix Zeroes                                              [Medium]
//  https://leetcode.com/problems/set-matrix-zeroes/
// ----------------------------------------------------------------------------
//  Wherever the matrix holds a zero, set that entire row and column to zero.
//  Do it in place; nothing is returned.
//
//  Examples
//    matrix = [[1,1,1],[1,0,1],[1,1,1]]  ->  matrix becomes [[1,0,1],[0,0,0],[1,0,1]]
//    matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]  ->  matrix becomes [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
//    matrix = [[1,2],[3,4]]  ->  matrix becomes [[1,2],[3,4]]
//
//  Constraints
//    1 <= rows, cols <= 200
//
//  Hints (read only as many as you need)
//    1. Zeroing as you find each zero is wrong: the zeros you write get read
//       as originals and cascade.
//    2. So do two passes. First record which rows and columns must be
//       cleared, then clear them.
//    3. For O(1) space, store those flags in the matrix first row and first
//       column, handling those two lines separately at the end.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(73)]
public sealed class SetMatrixZeroes : ProblemTests<SetMatrixZeroes>
{
    public void Solve(int[][] matrix)
    {
        throw new NotImplementedException();
    }
}
