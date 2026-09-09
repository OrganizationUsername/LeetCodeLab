namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  62. Unique Paths                                                   [Medium]
//  https://leetcode.com/problems/unique-paths/
// ----------------------------------------------------------------------------
//  A robot starts at the top-left of an m by n grid and may only move right
//  or down. Return how many distinct paths reach the bottom-right corner.
//
//  Examples
//    m = 3, n = 7  ->  28
//    m = 3, n = 2  ->  3
//    m = 1, n = 1  ->  1
//
//  Constraints
//    1 <= m, n <= 100
//    the answer fits in a 32-bit integer
//
//  Hints (read only as many as you need)
//    1. Every cell is reached only from above or from the left, so
//       paths[r][c] = paths[r-1][c] + paths[r][c-1].
//    2. The top row and left column each have exactly one path.
//    3. One row of the table is enough if you overwrite it left to right.
//       There is also a pure combinatorics answer, since every path is a
//       fixed multiset of moves.
//
//  Aim for O(m*n) time, O(n) space
// ============================================================================
[Problem(62)]
public sealed class UniquePaths : ProblemTests<UniquePaths>
{
    public int Solve(int m, int n)
    {
        throw new NotImplementedException();
    }
}
