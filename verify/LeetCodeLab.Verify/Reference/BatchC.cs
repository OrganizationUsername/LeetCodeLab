namespace LeetCodeLab.Verify.Reference;

[Problem(746)]
public sealed class MinCostClimbingStairs : ProblemTests<MinCostClimbingStairs>
{
    public int Solve(int[] cost)
    {
        int twoBack = 0, oneBack = 0;
        for (int i = 2; i <= cost.Length; i++)
        {
            int current = Math.Min(oneBack + cost[i - 1], twoBack + cost[i - 2]);
            twoBack = oneBack;
            oneBack = current;
        }
        return oneBack;
    }
}

[Problem(213)]
public sealed class HouseRobberII : ProblemTests<HouseRobberII>
{
    public int Solve(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        return Math.Max(Line(nums, 0, nums.Length - 2), Line(nums, 1, nums.Length - 1));
    }

    private static int Line(int[] nums, int lo, int hi)
    {
        int skip = 0, take = 0;
        for (int i = lo; i <= hi; i++) (skip, take) = (Math.Max(skip, take), skip + nums[i]);
        return Math.Max(skip, take);
    }
}

[Problem(647)]
public sealed class PalindromicSubstrings : ProblemTests<PalindromicSubstrings>
{
    public int Solve(string s)
    {
        int count = 0;

        void Expand(int lo, int hi)
        {
            while (lo >= 0 && hi < s.Length && s[lo] == s[hi]) { count++; lo--; hi++; }
        }

        for (int i = 0; i < s.Length; i++) { Expand(i, i); Expand(i, i + 1); }
        return count;
    }
}

[Problem(91)]
public sealed class DecodeWays : ProblemTests<DecodeWays>
{
    public int Solve(string s)
    {
        if (s.Length == 0 || s[0] == '0') return 0;

        int twoBack = 1, oneBack = 1;
        for (int i = 1; i < s.Length; i++)
        {
            int current = 0;
            if (s[i] != '0') current += oneBack;
            int pair = (s[i - 1] - '0') * 10 + (s[i] - '0');
            if (pair >= 10 && pair <= 26) current += twoBack;
            twoBack = oneBack;
            oneBack = current;
        }
        return oneBack;
    }
}

[Problem(152)]
public sealed class MaximumProductSubarray : ProblemTests<MaximumProductSubarray>
{
    public int Solve(int[] nums)
    {
        int best = nums[0], high = nums[0], low = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int value = nums[i];
            // Compute both from the old pair before either is overwritten.
            (high, low) = (Math.Max(value, Math.Max(high * value, low * value)),
                           Math.Min(value, Math.Min(high * value, low * value)));
            best = Math.Max(best, high);
        }
        return best;
    }
}

[Problem(55)]
public sealed class JumpGame : ProblemTests<JumpGame>
{
    public bool Solve(int[] nums)
    {
        int reach = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > reach) return false;
            reach = Math.Max(reach, i + nums[i]);
        }
        return true;
    }
}

[Problem(45)]
public sealed class JumpGameII : ProblemTests<JumpGameII>
{
    public int Solve(int[] nums)
    {
        int jumps = 0, windowEnd = 0, furthest = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(furthest, i + nums[i]);
            if (i == windowEnd) { jumps++; windowEnd = furthest; }
        }
        return jumps;
    }
}

[Problem(1143)]
public sealed class LongestCommonSubsequence : ProblemTests<LongestCommonSubsequence>
{
    public int Solve(string text1, string text2)
    {
        int[,] best = new int[text1.Length + 1, text2.Length + 1];
        for (int i = 1; i <= text1.Length; i++)
            for (int j = 1; j <= text2.Length; j++)
                best[i, j] = text1[i - 1] == text2[j - 1]
                    ? best[i - 1, j - 1] + 1
                    : Math.Max(best[i - 1, j], best[i, j - 1]);
        return best[text1.Length, text2.Length];
    }
}

[Problem(72)]
public sealed class EditDistance : ProblemTests<EditDistance>
{
    public int Solve(string word1, string word2)
    {
        int[,] best = new int[word1.Length + 1, word2.Length + 1];
        for (int i = 0; i <= word1.Length; i++) best[i, 0] = i;
        for (int j = 0; j <= word2.Length; j++) best[0, j] = j;

        for (int i = 1; i <= word1.Length; i++)
            for (int j = 1; j <= word2.Length; j++)
                best[i, j] = word1[i - 1] == word2[j - 1]
                    ? best[i - 1, j - 1]
                    : 1 + Math.Min(best[i - 1, j - 1], Math.Min(best[i - 1, j], best[i, j - 1]));

        return best[word1.Length, word2.Length];
    }
}

[Problem(62)]
public sealed class UniquePaths : ProblemTests<UniquePaths>
{
    public int Solve(int m, int n)
    {
        int[] row = new int[n];
        Array.Fill(row, 1);
        for (int r = 1; r < m; r++)
            for (int c = 1; c < n; c++)
                row[c] += row[c - 1];
        return row[n - 1];
    }
}

[Problem(64)]
public sealed class MinimumPathSum : ProblemTests<MinimumPathSum>
{
    public int Solve(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
            {
                if (r == 0 && c == 0) continue;
                if (r == 0) grid[r][c] += grid[r][c - 1];
                else if (c == 0) grid[r][c] += grid[r - 1][c];
                else grid[r][c] += Math.Min(grid[r - 1][c], grid[r][c - 1]);
            }
        return grid[rows - 1][cols - 1];
    }
}

[Problem(416)]
public sealed class PartitionEqualSubsetSum : ProblemTests<PartitionEqualSubsetSum>
{
    public bool Solve(int[] nums)
    {
        int total = nums.Sum();
        if (total % 2 != 0) return false;

        int half = total / 2;
        bool[] reachable = new bool[half + 1];
        reachable[0] = true;

        foreach (int value in nums)
            for (int sum = half; sum >= value; sum--)
                if (reachable[sum - value]) reachable[sum] = true;

        return reachable[half];
    }
}

[Problem(22)]
public sealed class GenerateParentheses : ProblemTests<GenerateParentheses>
{
    public IList<string> Solve(int n)
    {
        List<string> results = [];
        System.Text.StringBuilder current = new();

        void Build(int opened, int closed)
        {
            if (current.Length == 2 * n) { results.Add(current.ToString()); return; }

            if (opened < n)
            {
                current.Append('(');
                Build(opened + 1, closed);
                current.Length--;
            }
            if (closed < opened)
            {
                current.Append(')');
                Build(opened, closed + 1);
                current.Length--;
            }
        }

        Build(0, 0);
        return results;
    }
}

[Problem(17)]
public sealed class LetterCombinations : ProblemTests<LetterCombinations>
{
    private static readonly string[] Keys =
        ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];

    public IList<string> Solve(string digits)
    {
        List<string> results = [];
        if (digits.Length == 0) return results;

        char[] buffer = new char[digits.Length];

        void Build(int index)
        {
            if (index == digits.Length) { results.Add(new string(buffer)); return; }
            foreach (char letter in Keys[digits[index] - '0'])
            {
                buffer[index] = letter;
                Build(index + 1);
            }
        }

        Build(0);
        return results;
    }
}

[Problem(90)]
public sealed class SubsetsII : ProblemTests<SubsetsII>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> results = [];
        List<int> current = [];

        void Build(int start)
        {
            results.Add([.. current]);
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;
                current.Add(nums[i]);
                Build(i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }

        Build(0);
        return results;
    }
}

[Problem(973)]
public sealed class KClosestPointsToOrigin : ProblemTests<KClosestPointsToOrigin>
{
    public int[][] Solve(int[][] points, int k) =>
        [.. points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(k)];
}

[Problem(1046)]
public sealed class LastStoneWeight : ProblemTests<LastStoneWeight>
{
    public int Solve(int[] stones)
    {
        PriorityQueue<int, int> heaviest = new();
        foreach (int stone in stones) heaviest.Enqueue(stone, -stone);

        while (heaviest.Count > 1)
        {
            int a = heaviest.Dequeue(), b = heaviest.Dequeue();
            if (a != b) heaviest.Enqueue(a - b, -(a - b));
        }
        return heaviest.Count == 0 ? 0 : heaviest.Peek();
    }
}

[Problem(74)]
public sealed class SearchA2DMatrix : ProblemTests<SearchA2DMatrix>
{
    public bool Solve(int[][] matrix, int target)
    {
        int rows = matrix.Length, cols = matrix[0].Length;
        int lo = 0, hi = rows * cols - 1;

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            int value = matrix[mid / cols][mid % cols];
            if (value == target) return true;
            if (value < target) lo = mid + 1; else hi = mid - 1;
        }
        return false;
    }
}

[Problem(35)]
public sealed class SearchInsertPosition : ProblemTests<SearchInsertPosition>
{
    public int Solve(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) lo = mid + 1; else hi = mid - 1;
        }
        return lo;
    }
}

[Problem(232, Target = typeof(MyQueue))]
public sealed class MyQueueTests : ProblemTests<MyQueueTests>;

public class MyQueue
{
    private readonly Stack<int> _inbox = new();
    private readonly Stack<int> _outbox = new();

    public void Push(int x) => _inbox.Push(x);

    public int Pop() { Settle(); return _outbox.Pop(); }

    public int Peek() { Settle(); return _outbox.Peek(); }

    public bool Empty() => _inbox.Count == 0 && _outbox.Count == 0;

    // Only tip when the outbox is empty, or the ordering interleaves.
    private void Settle()
    {
        if (_outbox.Count > 0) return;
        while (_inbox.Count > 0) _outbox.Push(_inbox.Pop());
    }
}
