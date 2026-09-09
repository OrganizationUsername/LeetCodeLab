namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  733. Flood Fill                                                      [Easy]
//  https://leetcode.com/problems/flood-fill/
// ----------------------------------------------------------------------------
//  Starting from pixel (sr, sc), repaint it and every edge-connected pixel of
//  the same original colour with the new colour. Return the image.
//
//  Examples
//    image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2  ->  [[2,2,2],[2,2,0],[2,0,1]]
//    image = [[0,0,0],[0,0,0]], sr = 0, sc = 0, color = 0  ->  [[0,0,0],[0,0,0]]
//    image = [[0,0,0],[0,1,1]], sr = 1, sc = 1, color = 1  ->  [[0,0,0],[0,1,1]]
//
//  Constraints
//    1 <= rows, cols <= 50
//    0 <= colour values <= 65535
//
//  Hints (read only as many as you need)
//    1. Record the starting colour BEFORE you repaint anything, or the
//       comparison changes under you.
//    2. Then depth-first search, repainting cells that still hold that
//       original colour.
//    3. Watch the case where the new colour already equals the original:
//       repainting changes nothing, so the recursion never terminates. Return
//       early.
//
//  Aim for O(rows * cols) time
// ============================================================================
[Problem(733)]
public sealed class FloodFill : ProblemTests<FloodFill>
{
    public int[][] Solve(int[][] image, int sr, int sc, int color)
    {
        throw new NotImplementedException();
    }
}
