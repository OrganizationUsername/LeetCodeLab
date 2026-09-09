namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  1091. Shortest Path in Binary Matrix                               [Medium]
//  https://leetcode.com/problems/shortest-path-in-binary-matrix/
// ----------------------------------------------------------------------------
//  In an n by n grid, 0 is clear and 1 is blocked. Walk from the top-left
//  corner to the bottom-right, moving to any of the EIGHT surrounding cells.
//  Return the number of CELLS on the shortest clear path, counting both ends,
//  or -1 if there is none.
//
//  Examples
//    grid = [[0,1],[1,0]]  ->  2
//    grid = [[0,0,0],[1,1,0],[1,1,0]]  ->  4
//    grid = [[1,0,0],[1,1,0],[1,1,0]]  ->  -1
//
//  Constraints
//    1 <= n <= 100
//    cells are 0 or 1
//    movement is 8-directional, including diagonals
//    the answer counts cells visited, not steps taken, so a 1x1 clear grid answers 1
//
//  Hints (read only as many as you need)
//    1. Every move costs the same, so breadth-first search finds the shortest
//       path; no priority queue is needed.
//    2. The only differences from a normal grid search are eight offsets
//       instead of four, and that the answer counts cells rather than edges.
//    3. Check both endpoints before you start: if the start or the goal is
//       blocked the answer is -1 immediately. Mark cells visited as you
//       enqueue them, or the eight-way branching will queue the same cell
//       many times over.
//
//  Aim for O(n^2) time
// ============================================================================
[Problem(1091)]
public sealed class ShortestPathInBinaryMatrix : ProblemTests<ShortestPathInBinaryMatrix>
{
    public int Solve(int[][] grid)
    {
        throw new NotImplementedException();
    }
}
