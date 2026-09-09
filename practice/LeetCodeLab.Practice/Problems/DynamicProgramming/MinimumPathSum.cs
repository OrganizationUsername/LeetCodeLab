namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  64. Minimum Path Sum                                               [Medium]
//  https://leetcode.com/problems/minimum-path-sum/
// ----------------------------------------------------------------------------
//  Walk from the top-left to the bottom-right of the grid moving only right
//  or down. Return the smallest possible sum of the values visited.
//
//  Examples
//    grid = [[1,3,1],[1,5,1],[4,2,1]]  ->  7
//    grid = [[1,2,3],[4,5,6]]  ->  12
//    grid = [[5]]  ->  5
//
//  Constraints
//    1 <= rows, cols <= 200
//    0 <= grid[i][j] <= 200
//
//  Hints (read only as many as you need)
//    1. Greedy choice at each step is wrong; a cheap first move can lead into
//       an expensive region.
//    2. best[r][c] = grid[r][c] + min(best[r-1][c], best[r][c-1]).
//    3. The top row and left column have only one way in, so fill them as
//       running sums first. You can write the answers into the grid itself.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(64)]
public sealed class MinimumPathSum : ProblemTests<MinimumPathSum>
{
    public int Solve(int[][] grid)
    {
        throw new NotImplementedException();
    }
}
