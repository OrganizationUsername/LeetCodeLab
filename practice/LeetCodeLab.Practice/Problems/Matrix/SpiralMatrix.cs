using System.Diagnostics.Metrics;

namespace LeetCodeLab.Practice.Problems.Matrix;

// ============================================================================
//  54. Spiral Matrix                                                  [Medium]
//  https://leetcode.com/problems/spiral-matrix/
// ----------------------------------------------------------------------------
//  Return all values of the matrix read in spiral order: left to right along
//  the top, down the right side, right to left along the bottom, up the left
//  side, then inward.
//
//  Examples
//    matrix = [[1,2,3],[4,5,6],[7,8,9]]  ->  [1,2,3,6,9,8,7,4,5]
//    matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]  ->  [1,2,3,4,8,12,11,10,9,5,6,7]
//    matrix = [[7],[9],[6]]  ->  [7,9,6]
//
//  Constraints
//    1 <= rows, cols <= 10
//
//  Hints (read only as many as you need)
//    1. Hold four boundaries: top, bottom, left and right.
//    2. Walk one edge at a time and shrink the corresponding boundary
//       afterwards.
//    3. The trap is a non-square matrix, where you can exhaust the rows
//       before the columns. Re-check that the boundaries have not crossed
//       before the bottom edge and the left edge.
//
//  Aim for O(rows*cols) time
// ============================================================================
[Problem(54)]
public sealed class SpiralMatrix : ProblemTests<SpiralMatrix>
{
    public IList<int> Solve(int[][] matrix)
    {
        var result = new List<int>();

        var minX = -1;
        var maxX = matrix[0].GetLength(0);
        var minY = -1;
        var maxY = matrix.GetLength(0);

        var currentX = 0;
        var currentY = 0;
        var counted = 0;
        var total = maxX * maxY;

        var ds = new List<Direction>
        {
            new(){X= 01, Cardinal = Cardinal.Right,},
            new(){Y= 01, Cardinal = Cardinal.Down,},
            new(){X= -1, Cardinal = Cardinal.Left,},
            new(){Y= -1, Cardinal = Cardinal.Up,},
        };

        result.Add(matrix[0][0]);
        counted++;
        while (counted < total)
        {
            foreach (var direction in ds)
            {
                if (counted == total) { return result; }

                while (counted < total)
                {
                    var shouldBreak = false;
                    switch (direction.Cardinal)
                    {
                        case Cardinal.Right: if (currentX + direction.X == maxX) { shouldBreak = true; minY++; } break;
                        case Cardinal.Down: if (currentY + direction.Y == maxY) { shouldBreak = true; maxX--; } break;
                        case Cardinal.Left: if (currentX + direction.X == minX) { shouldBreak = true; maxY--; } break;
                        case Cardinal.Up: if (currentY + direction.Y == minY) { shouldBreak = true; minX++; } break;
                    }

                    if (shouldBreak) { break; }

                    currentX += direction.X;
                    currentY += direction.Y;
                    result.Add(matrix[currentY][currentX]);
                    counted++;
                }
            }
        }
        return result;
    }

    public class Direction
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Cardinal Cardinal { get; set; }
    }
    public enum Cardinal { Right = 0, Down = 1, Left = 2, Up = 3, }
}
