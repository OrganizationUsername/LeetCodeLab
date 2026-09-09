namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  212. Word Search II                                                  [Hard]
//  https://leetcode.com/problems/word-search-ii/
// ----------------------------------------------------------------------------
//  Return every word from the list that can be spelled by walking the board
//  between side-adjacent cells, without using any cell twice within one word.
//  Order does not matter and each found word is reported once.
//
//  Examples
//    board = [["o","a","a","n"],["e","t","a","e"],["i","..., words = ["oath","pea","eat","rain"]  ->  ["oath","eat"]
//    board = [["a","b"],["c","d"]], words = ["abcb"]  ->  []
//    board = [["a"]], words = ["a"]  ->  ["a"]
//
//  Constraints
//    1 <= rows, cols <= 12
//    1 <= words.Length <= 3*10^4
//    a cell may not be reused within a single word, but words are independent of each other
//    the answer may be returned in any order
//
//  Hints (read only as many as you need)
//    1. Running Word Search once per word re-walks the same board thousands
//       of times. The words share prefixes; exploit that.
//    2. Build a trie of the words, then run ONE backtracking search over the
//       board, descending the trie as you step. Abandon a branch the moment
//       the trie has no child for the letter you are standing on.
//    3. Two things make this fast enough: mark a word found at the trie node
//       rather than searching for it, and prune the trie as you go - once a
//       word is collected, clear its end marker, and leaf nodes with no
//       children can be unlinked so later searches never revisit them.
//
//  Aim for O(cells * 4^maxWordLength) worst case, far less with pruning
// ============================================================================
[Problem(212)]
public sealed class WordSearchII : ProblemTests<WordSearchII>
{
    public IList<string> Solve(char[][] board, string[] words)
    {
        throw new NotImplementedException();
    }
}
