namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  695. Max Area of Island                                            [Medium]
//  https://leetcode.com/problems/max-area-of-island/
// ----------------------------------------------------------------------------
//  The grid holds 0 for water and 1 for land. An island is land joined edge
//  to edge. Return the size of the largest island, or 0 when there is none.
//
//  Examples
//    grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0...  ->  6
//    grid = [[0,0,0,0,0,0,0,0]]  ->  0
//    grid = [[1,1],[1,0]]  ->  3
//
//  Constraints
//    1 <= rows, cols <= 50
//
//  Hints (read only as many as you need)
//    1. Same sweep as Number of Islands, but the flood must COUNT what it
//       visits.
//    2. Have the recursion return 1 plus the sum of the four neighbouring
//       calls.
//    3. Mark visited cells as you go, by overwriting with 0 or with a
//       separate visited grid, or the count will run away.
//
//  Aim for O(rows * cols) time
// ============================================================================
[Problem(695)]
public sealed class MaxAreaOfIsland : ProblemTests<MaxAreaOfIsland>
{
    public int Solve(int[][] grid)
    {
        throw new NotImplementedException();
    }
}
