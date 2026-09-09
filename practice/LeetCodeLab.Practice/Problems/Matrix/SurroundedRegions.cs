namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  130. Surrounded Regions                                            [Medium]
//  https://leetcode.com/problems/surrounded-regions/
// ----------------------------------------------------------------------------
//  The board holds the characters X and O. An O region is captured when it is
//  completely surrounded by X, meaning no cell of the region touches the
//  border. Flip every captured region to X in place. The answer is the
//  mutated board rather than a return value.
//
//  Examples
//    board = [["X","X","X","X"],["X","O","O","X"],["X","...  ->  board becomes [["X","X","X","X"],["X","X","X","X"],["X","...
//    board = [["X"]]  ->  board becomes [["X"]]
//    board = [["O"]]  ->  board becomes [["O"]]
//
//  Constraints
//    1 <= rows, cols <= 200
//    entries are the characters 'X' and 'O'
//    a region connects through the four side-adjacent neighbours, not diagonally
//
//  Hints (read only as many as you need)
//    1. Searching each O region and asking whether it reached the border
//       works, but it re-walks regions and is fiddly to get right.
//    2. Invert the question. Rather than finding the surrounded regions, find
//       the SURVIVORS: every O reachable from an O on the border.
//    3. Flood fill inward from the border Os, marking them temporarily. Then
//       one sweep: marked cells become O, every other O becomes X. This is
//       the same border-seeded idea as Pacific Atlantic Water Flow.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(130)]
public sealed class SurroundedRegions : ProblemTests<SurroundedRegions>
{
    public void Solve(char[][] board)
    {
        throw new NotImplementedException();
    }
}
