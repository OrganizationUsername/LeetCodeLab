namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  994. Rotting Oranges                                               [Medium]
//  https://leetcode.com/problems/rotting-oranges/
// ----------------------------------------------------------------------------
//  Cells hold 0 for empty, 1 for a fresh orange and 2 for a rotten one. Every
//  minute, any fresh orange edge-adjacent to a rotten one also rots. Return
//  the minutes until no fresh orange remains, or -1 if that never happens.
//
//  Examples
//    grid = [[2,1,1],[1,1,0],[0,1,1]]  ->  4
//    grid = [[2,1,1],[0,1,1],[1,0,1]]  ->  -1
//    grid = [[0,2]]  ->  0
//
//  Constraints
//    1 <= rows, cols <= 10
//    cell values are 0, 1 or 2
//
//  Hints (read only as many as you need)
//    1. Rot spreads outward in simultaneous waves, which is breadth-first
//       search, not depth-first.
//    2. Seed the queue with EVERY initially rotten orange, so all sources
//       expand together. Count the fresh ones as you go.
//    3. Process the queue one full level per minute. At the end, any fresh
//       orange left unreached means -1. Zero fresh oranges at the start means
//       0.
//
//  Aim for O(rows * cols) time
// ============================================================================
[Problem(994)]
public sealed class RottingOranges : ProblemTests<RottingOranges>
{
    public int Solve(int[][] grid)
    {
        throw new NotImplementedException();
    }
}
