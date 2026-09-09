namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  221. Maximal Square                                                [Medium]
//  https://leetcode.com/problems/maximal-square/
// ----------------------------------------------------------------------------
//  The grid holds the characters 1 and 0. Find the largest square made
//  entirely of 1s and return its AREA, not its side length.
//
//  Examples
//    matrix = [["1","0","1","0","0"],["1","0","1","1","1"...  ->  4
//    matrix = [["0","1"],["1","0"]]  ->  1
//    matrix = [["0"]]  ->  0
//
//  Constraints
//    1 <= rows, cols <= 300
//    entries are the characters '0' and '1'
//    return 0 when there is no 1 anywhere
//
//  Hints (read only as many as you need)
//    1. Checking every candidate square is far too slow. Ask instead: for
//       each cell, what is the largest square whose BOTTOM-RIGHT corner is
//       exactly here?
//    2. A square of side k ending at a cell requires squares of side k-1
//       ending at the cells directly above, directly left, and diagonally
//       up-left. Any one of them being smaller caps you.
//    3. So dp[i][j] = min of those three neighbours, plus one, when the cell
//       is a 1. Track the largest dp value and square it at the end -
//       forgetting to square is the usual slip, since the DP is in side
//       lengths and the answer is an area.
//
//  Aim for O(rows*cols) time, O(cols) space if you keep one row
// ============================================================================
[Problem(221)]
public sealed class MaximalSquare : ProblemTests<MaximalSquare>
{
    public int Solve(char[][] matrix)
    {
        throw new NotImplementedException();
    }
}
