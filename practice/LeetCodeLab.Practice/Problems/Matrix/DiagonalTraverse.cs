namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  498. Diagonal Traverse                                             [Medium]
//  https://leetcode.com/problems/diagonal-traverse/
// ----------------------------------------------------------------------------
//  Read the matrix in diagonal order, zig-zagging: the first diagonal travels
//  up and to the right, the next travels down and to the left, and so on.
//  Return the values in the order visited.
//
//  Examples
//    mat = [[1,2,3],[4,5,6],[7,8,9]]  ->  [1,2,4,7,5,3,6,8,9]
//    mat = [[1,2],[3,4]]  ->  [1,2,3,4]
//    mat = [[7]]  ->  [7]
//
//  Constraints
//    1 <= rows, cols <= 10^4
//    1 <= rows*cols <= 10^4
//
//  Hints (read only as many as you need)
//    1. Every cell on one diagonal shares the same row+col. Grouping by that
//       sum turns this into a bucketing problem rather than a walking one.
//    2. There are rows+cols-1 diagonals. For each, collect its cells, then
//       reverse the order on alternating diagonals so the zig-zag comes out
//       right.
//    3. If you walk it instead of bucketing, the awkward part is turning a
//       corner: when you run off the top going up-right you move RIGHT if you
//       can and DOWN otherwise, and the mirror of that going down-left.
//       Getting those two fallbacks the wrong way round is the classic bug,
//       and it only shows on non-square input.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(498)]
public sealed class DiagonalTraverse : ProblemTests<DiagonalTraverse>
{
    public int[] Solve(int[][] mat)
    {
        throw new NotImplementedException();
    }
}
