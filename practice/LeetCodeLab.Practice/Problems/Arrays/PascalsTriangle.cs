namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  118. Pascals Triangle                                                [Easy]
//  https://leetcode.com/problems/pascals-triangle/
// ----------------------------------------------------------------------------
//  Return the first numRows rows of Pascal triangle. Each row starts and ends
//  with 1, and every other entry is the sum of the two entries above it.
//
//  Examples
//    numRows = 5  ->  [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
//    numRows = 1  ->  [[1]]
//    numRows = 2  ->  [[1],[1,1]]
//
//  Constraints
//    1 <= numRows <= 30
//
//  Hints (read only as many as you need)
//    1. Build row by row, using only the row you just produced.
//    2. A row of length L starts and ends with 1; entry j in between is
//       previous[j-1] + previous[j].
//    3. Row order matters here, so return them top to bottom.
//
//  Aim for O(numRows^2) time
// ============================================================================
[Problem(118)]
public sealed class PascalsTriangle : ProblemTests<PascalsTriangle>
{
    public IList<IList<int>> Solve(int numRows)
    {
        throw new NotImplementedException();
    }
}
