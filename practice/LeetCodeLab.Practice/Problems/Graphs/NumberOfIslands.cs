namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  200. Number of Islands                                             [Medium]
//  https://leetcode.com/problems/number-of-islands/
// ----------------------------------------------------------------------------
//  The grid holds the characters 1 for land and 0 for water. An island is a
//  group of land cells joined edge to edge, not diagonally. Return how many
//  islands there are.
//
//  Examples
//    grid = [["1","1","1","1","0"],["1","1","0","1","0"...  ->  1
//    grid = [["1","1","0","0","0"],["1","1","0","0","0"...  ->  3
//
//  Constraints
//    1 <= rows, cols <= 300
//
//  Hints (read only as many as you need)
//    1. Scan every cell. When you hit land you have found a new island, so
//       increment the counter.
//    2. Then immediately flood the entire island so you never count it again,
//       by depth-first or breadth-first search from that cell.
//    3. The simplest flood overwrites each visited land cell with 0. Mutating
//       the input is allowed here.
//
//  Aim for O(rows * cols) time
// ============================================================================
[Problem(200)]
public sealed class NumberOfIslands : ProblemTests<NumberOfIslands>
{
    public int Solve(char[][] grid)
    {
        throw new NotImplementedException();
    }
}
