namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the matrix batch. They exist only to prove the case files.

[Problem(59)]
public sealed class SpiralMatrixII : ProblemTests<SpiralMatrixII>
{
    public int[][] Solve(int n)
    {
        int[][] m = new int[n][];
        for (int i = 0; i < n; i++) m[i] = new int[n];

        int top = 0, bottom = n - 1, left = 0, right = n - 1, value = 1;
        while (top <= bottom && left <= right)
        {
            for (int x = left; x <= right; x++) m[top][x] = value++;
            top++;
            for (int y = top; y <= bottom; y++) m[y][right] = value++;
            right--;
            if (top <= bottom) { for (int x = right; x >= left; x--) m[bottom][x] = value++; bottom--; }
            if (left <= right) { for (int y = bottom; y >= top; y--) m[y][left] = value++; left++; }
        }
        return m;
    }
}

[Problem(867)]
public sealed class TransposeMatrix : ProblemTests<TransposeMatrix>
{
    public int[][] Solve(int[][] matrix)
    {
        int rows = matrix.Length, cols = matrix[0].Length;
        int[][] result = new int[cols][];
        for (int j = 0; j < cols; j++)
        {
            result[j] = new int[rows];
            for (int i = 0; i < rows; i++) result[j][i] = matrix[i][j];
        }
        return result;
    }
}

[Problem(566)]
public sealed class ReshapeTheMatrix : ProblemTests<ReshapeTheMatrix>
{
    public int[][] Solve(int[][] mat, int r, int c)
    {
        int rows = mat.Length, cols = mat[0].Length;
        if (rows * cols != r * c) return mat;

        int[][] result = new int[r][];
        for (int i = 0; i < r; i++) result[i] = new int[c];
        for (int k = 0; k < rows * cols; k++) result[k / c][k % c] = mat[k / cols][k % cols];
        return result;
    }
}

[Problem(498)]
public sealed class DiagonalTraverse : ProblemTests<DiagonalTraverse>
{
    public int[] Solve(int[][] mat)
    {
        int rows = mat.Length, cols = mat[0].Length;
        int[] result = new int[rows * cols];
        int at = 0;

        for (int d = 0; d < rows + cols - 1; d++)
        {
            if (d % 2 == 0)
                for (int i = Math.Min(d, rows - 1); i >= 0 && d - i < cols; i--)
                    result[at++] = mat[i][d - i];
            else
                for (int i = Math.Max(0, d - cols + 1); i < rows && d - i >= 0; i++)
                    result[at++] = mat[i][d - i];
        }
        return result;
    }
}

[Problem(240)]
public sealed class SearchA2DMatrixII : ProblemTests<SearchA2DMatrixII>
{
    public bool Solve(int[][] matrix, int target)
    {
        // Stand at the top-right: left is always smaller, down is always larger.
        int row = 0, col = matrix[0].Length - 1;
        while (row < matrix.Length && col >= 0)
        {
            if (matrix[row][col] == target) return true;
            if (matrix[row][col] > target) col--; else row++;
        }
        return false;
    }
}

[Problem(221)]
public sealed class MaximalSquare : ProblemTests<MaximalSquare>
{
    public int Solve(char[][] matrix)
    {
        int rows = matrix.Length, cols = matrix[0].Length, best = 0;
        int[,] side = new int[rows + 1, cols + 1];

        for (int i = 1; i <= rows; i++)
            for (int j = 1; j <= cols; j++)
                if (matrix[i - 1][j - 1] == '1')
                {
                    side[i, j] = Math.Min(side[i - 1, j], Math.Min(side[i, j - 1], side[i - 1, j - 1])) + 1;
                    best = Math.Max(best, side[i, j]);
                }

        return best * best;
    }
}

[Problem(130)]
public sealed class SurroundedRegions : ProblemTests<SurroundedRegions>
{
    public void Solve(char[][] board)
    {
        int rows = board.Length, cols = board[0].Length;
        Queue<(int Row, int Col)> queue = new();

        void Seed(int r, int c)
        {
            if (board[r][c] != 'O') return;
            board[r][c] = '#';
            queue.Enqueue((r, c));
        }

        for (int r = 0; r < rows; r++) { Seed(r, 0); Seed(r, cols - 1); }
        for (int c = 0; c < cols; c++) { Seed(0, c); Seed(rows - 1, c); }

        int[] dr = [1, -1, 0, 0], dc = [0, 0, 1, -1];
        while (queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                int nr = row + dr[k], nc = col + dc[k];
                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols) Seed(nr, nc);
            }
        }

        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                board[r][c] = board[r][c] == '#' ? 'O' : 'X';
    }
}

[Problem(542)]
public sealed class ZeroOneMatrix : ProblemTests<ZeroOneMatrix>
{
    public int[][] Solve(int[][] mat)
    {
        int rows = mat.Length, cols = mat[0].Length;
        int[][] distance = new int[rows][];
        Queue<(int Row, int Col)> queue = new();

        for (int r = 0; r < rows; r++)
        {
            distance[r] = new int[cols];
            for (int c = 0; c < cols; c++)
            {
                if (mat[r][c] == 0) queue.Enqueue((r, c));
                else distance[r][c] = -1;
            }
        }

        int[] dr = [1, -1, 0, 0], dc = [0, 0, 1, -1];
        while (queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                int nr = row + dr[k], nc = col + dc[k];
                if (nr < 0 || nr >= rows || nc < 0 || nc >= cols || distance[nr][nc] != -1) continue;
                distance[nr][nc] = distance[row][col] + 1;
                queue.Enqueue((nr, nc));
            }
        }
        return distance;
    }
}

[Problem(304, Target = typeof(NumMatrix))]
public sealed class RangeSumQuery2DTests : ProblemTests<RangeSumQuery2DTests>;

public class NumMatrix
{
    private readonly int[,] _prefix;

    public NumMatrix(int[][] matrix)
    {
        int rows = matrix.Length, cols = matrix[0].Length;
        _prefix = new int[rows + 1, cols + 1];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                _prefix[i + 1, j + 1] =
                    matrix[i][j] + _prefix[i, j + 1] + _prefix[i + 1, j] - _prefix[i, j];
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
        => _prefix[row2 + 1, col2 + 1] - _prefix[row1, col2 + 1]
         - _prefix[row2 + 1, col1] + _prefix[row1, col1];
}
