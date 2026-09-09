namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  72. Edit Distance                                                  [Medium]
//  https://leetcode.com/problems/edit-distance/
// ----------------------------------------------------------------------------
//  Return the minimum number of single-character insertions, deletions or
//  replacements needed to turn word1 into word2.
//
//  Examples
//    word1 = "horse", word2 = "ros"  ->  3
//    word1 = "intention", word2 = "execution"  ->  5
//    word1 = "", word2 = "abc"  ->  3
//
//  Constraints
//    0 <= each length <= 500
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. Another two-dimensional table: best[i][j] is the cost of converting
//       the first i characters into the first j.
//    2. Seed the edges: converting a prefix into the empty string costs one
//       deletion per character, and vice versa.
//    3. On a character match, carry best[i-1][j-1] across for free. Otherwise
//       take 1 + the minimum of the three neighbours, which correspond to
//       replace, delete and insert.
//
//  Aim for O(n*m) time
// ============================================================================
[Problem(72)]
public sealed class EditDistance : ProblemTests<EditDistance>
{
    public int Solve(string word1, string word2)
    {
        throw new NotImplementedException();
    }
}
