namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  74. Search a 2D Matrix                                             [Medium]
//  https://leetcode.com/problems/search-a-2d-matrix/
// ----------------------------------------------------------------------------
//  Each row is sorted ascending, and the first value of each row is greater
//  than the last value of the previous row. Return whether target is present,
//  in logarithmic time.
//
//  Examples
//    matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3  ->  true
//    matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13  ->  false
//    matrix = [[1]], target = 1  ->  true
//
//  Constraints
//    1 <= rows, cols <= 100
//    the matrix is fully sorted when read row by row
//
//  Hints (read only as many as you need)
//    1. Because of the second condition, reading the matrix row by row gives
//       one single sorted sequence.
//    2. So run an ordinary binary search over the index range 0 to rows*cols
//       - 1.
//    3. Convert a flat index back with row = index / cols and column = index
//       % cols.
//
//  Aim for O(log(rows*cols)) time
// ============================================================================
[Problem(74)]
public sealed class SearchA2DMatrix : ProblemTests<SearchA2DMatrix>
{
    public bool Solve(int[][] matrix, int target)
    {
        throw new NotImplementedException();
    }
}
