namespace LeetCodeLab.Practice.Problems.Simulation;

// ============================================================================
//  289. Game of Life                                                  [Medium]
//  https://leetcode.com/problems/game-of-life/
// ----------------------------------------------------------------------------
//  Each cell is 1 for live or 0 for dead and has up to eight neighbours.
//  Advance the board one generation in place: a live cell with fewer than two
//  or more than three live neighbours dies, a live cell with two or three
//  survives, and a dead cell with exactly three live neighbours comes alive.
//  Every cell updates simultaneously from the ORIGINAL board, and the answer
//  is the mutated board rather than a return value.
//
//  Examples
//    board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]  ->  board becomes [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
//    board = [[1,1],[1,0]]  ->  board becomes [[1,1],[1,1]]
//    board = [[0,1,0],[0,1,0],[0,1,0]]  ->  board becomes [[0,0,0],[1,1,1],[0,0,0]]
//
//  Constraints
//    1 <= rows, cols <= 25
//    board[i][j] is 0 or 1
//    cells outside the board are treated as dead
//
//  Hints (read only as many as you need)
//    1. The trap is updating in place while still reading neighbours: a cell
//       you already flipped would feed the wrong value to its neighbour.
//    2. Copying the board first is the honest fix and costs O(mn) extra
//       memory. Now find the version that needs none.
//    3. Each cell only has to remember two bits: what it was and what it
//       becomes. Encode the next state in a second bit (write 2 for a cell
//       that changes, say) so the old state survives the pass, then divide it
//       away in a second pass.
//
//  Aim for O(mn) time, O(1) extra space
// ============================================================================
[Problem(289)]
public sealed class GameOfLife : ProblemTests<GameOfLife>
{
    public void Solve(int[][] board)
    {
        throw new NotImplementedException();
    }
}
