namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  79. Word Search                                                    [Medium]
//  https://leetcode.com/problems/word-search/
// ----------------------------------------------------------------------------
//  Return true if word can be spelled by walking the grid from cell to cell
//  through shared edges, without reusing a cell within that path. Cells may
//  be reused across different starting attempts.
//
//  Examples
//    board = [["A","B","C","E"],["S","F","C","S"],["A","..., word = "ABCCED"  ->  true
//    board = [["A","B","C","E"],["S","F","C","S"],["A","..., word = "SEE"  ->  true
//    board = [["A","B","C","E"],["S","F","C","S"],["A","..., word = "ABCB"  ->  false
//
//  Constraints
//    1 <= rows, cols <= 6
//    1 <= word.Length <= 15
//
//  Hints (read only as many as you need)
//    1. Try to start the walk from every cell, and depth-first search from
//       each.
//    2. At each step the current cell must match the current letter;
//       otherwise this path fails immediately.
//    3. Mark the cell as visited before recursing and restore it afterwards.
//       Overwriting with a sentinel character avoids a second visited array.
//
//  Aim for O(rows * cols * 4^len) worst case
// ============================================================================
[Problem(79)]
public sealed class WordSearch : ProblemTests<WordSearch>
{
    public bool Solve(char[][] board, string word)
    {
        throw new NotImplementedException();
    }
}
