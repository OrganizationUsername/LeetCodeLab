namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  542. 01 Matrix                                                     [Medium]
//  https://leetcode.com/problems/01-matrix/
// ----------------------------------------------------------------------------
//  For every cell return its distance to the nearest 0, counting steps
//  between side-adjacent cells. Cells holding 0 have distance 0. At least one
//  0 is always present.
//
//  Examples
//    mat = [[0,0,0],[0,1,0],[0,0,0]]  ->  [[0,0,0],[0,1,0],[0,0,0]]
//    mat = [[0,0,0],[0,1,0],[1,1,1]]  ->  [[0,0,0],[0,1,0],[1,2,1]]
//    mat = [[0]]  ->  [[0]]
//
//  Constraints
//    1 <= rows, cols <= 10^4
//    1 <= rows*cols <= 10^4
//    entries are 0 or 1, and at least one 0 exists
//
//  Hints (read only as many as you need)
//    1. A separate search starting from each 1 is correct and far too slow.
//       Turn the search around.
//    2. Start from every 0 at once. Push all of them into the queue before
//       the loop begins, and the first time a breadth-first search reaches a
//       cell, that is its shortest distance.
//    3. This multi-source trick is the same one behind Rotting Oranges and
//       Load Path to Ground. There is also a two-pass dynamic programming
//       solution - sweep top-left to bottom-right, then bottom-right to
//       top-left - which needs no queue at all.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(542)]
public sealed class ZeroOneMatrix : ProblemTests<ZeroOneMatrix>
{
    public int[][] Solve(int[][] mat)
    {
        throw new NotImplementedException();
    }
}
