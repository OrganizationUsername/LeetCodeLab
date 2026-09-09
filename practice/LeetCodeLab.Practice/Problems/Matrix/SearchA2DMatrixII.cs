namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  240. Search a 2D Matrix II                                         [Medium]
//  https://leetcode.com/problems/search-a-2d-matrix-ii/
// ----------------------------------------------------------------------------
//  Every row increases left to right and every column increases top to
//  bottom, but unlike Search a 2D Matrix the rows do NOT continue from one
//  another: the first value of a row may be smaller than the last value of
//  the row above. Return whether the target is present.
//
//  Examples
//    matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],..., target = 5  ->  true
//    matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],..., target = 20  ->  false
//    matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],..., target = 1  ->  true
//
//  Constraints
//    1 <= rows, cols <= 300
//    rows are sorted ascending and columns are sorted ascending
//    flattening to one sorted list is not valid here
//
//  Hints (read only as many as you need)
//    1. Binary searching each row is O(rows log cols) and ignores the column
//       ordering. There is a linear walk that uses both orderings at once.
//    2. Look for a corner where the two directions disagree - one where going
//       one way always increases and the other always decreases. The
//       top-right is such a corner.
//    3. Stand at the top-right. If the value is larger than the target the
//       whole column is too large, so move left; if smaller, the whole row is
//       too small, so move down. Each step retires a row or a column, giving
//       O(rows + cols). The bottom-left corner works identically.
//
//  Aim for O(rows + cols) time, O(1) space
// ============================================================================
[Problem(240)]
public sealed class SearchA2DMatrixII : ProblemTests<SearchA2DMatrixII>
{
    public bool Solve(int[][] matrix, int target)
    {
        throw new NotImplementedException();
    }
}
