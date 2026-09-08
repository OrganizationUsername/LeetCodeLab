using System.Text.Json;

namespace LeetCodeLab.Verify.Reference;

[Problem(215)]
public sealed class KthLargestElementInAnArray : ProblemTests<KthLargestElementInAnArray>
{
    public int Solve(int[] nums, int k)
    {
        int[] sorted = [.. nums];
        Array.Sort(sorted);
        return sorted[^k];
    }
}

[Problem(39)]
public sealed class CombinationSum : ProblemTests<CombinationSum>
{
    public IList<IList<int>> Solve(int[] candidates, int target)
    {
        List<IList<int>> result = [];
        Build(candidates, target, 0, [], result);
        return result;
    }

    private static void Build(int[] candidates, int remaining, int start,
        List<int> current, List<IList<int>> result)
    {
        if (remaining == 0) { result.Add([.. current]); return; }
        if (remaining < 0) return;

        for (int i = start; i < candidates.Length; i++)
        {
            current.Add(candidates[i]);
            Build(candidates, remaining - candidates[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}

[Problem(46)]
public sealed class Permutations : ProblemTests<Permutations>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        List<IList<int>> result = [];
        Build(nums, new bool[nums.Length], [], result);
        return result;
    }

    private static void Build(int[] nums, bool[] used, List<int> current, List<IList<int>> result)
    {
        if (current.Count == nums.Length) { result.Add([.. current]); return; }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            current.Add(nums[i]);
            Build(nums, used, current, result);
            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
    }
}

[Problem(78)]
public sealed class Subsets : ProblemTests<Subsets>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        List<IList<int>> result = [];
        for (int mask = 0; mask < (1 << nums.Length); mask++)
        {
            List<int> subset = [];
            for (int i = 0; i < nums.Length; i++)
                if ((mask & (1 << i)) != 0) subset.Add(nums[i]);
            result.Add(subset);
        }
        return result;
    }
}

[Problem(79)]
public sealed class WordSearch : ProblemTests<WordSearch>
{
    public bool Solve(char[][] board, string word)
    {
        for (int r = 0; r < board.Length; r++)
            for (int c = 0; c < board[r].Length; c++)
                if (Explore(board, word, r, c, 0)) return true;
        return false;
    }

    private static bool Explore(char[][] board, string word, int r, int c, int index)
    {
        if (index == word.Length) return true;
        if (r < 0 || r >= board.Length || c < 0 || c >= board[r].Length) return false;
        if (board[r][c] != word[index]) return false;

        char original = board[r][c];
        board[r][c] = '\0';
        bool found = Explore(board, word, r + 1, c, index + 1)
            || Explore(board, word, r - 1, c, index + 1)
            || Explore(board, word, r, c + 1, index + 1)
            || Explore(board, word, r, c - 1, index + 1);
        board[r][c] = original;
        return found;
    }
}

[Problem(200)]
public sealed class NumberOfIslands : ProblemTests<NumberOfIslands>
{
    public int Solve(char[][] grid)
    {
        int count = 0;
        for (int r = 0; r < grid.Length; r++)
            for (int c = 0; c < grid[r].Length; c++)
                if (grid[r][c] == '1') { Sink(grid, r, c); count++; }
        return count;
    }

    private static void Sink(char[][] grid, int r, int c)
    {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[r].Length || grid[r][c] != '1') return;
        grid[r][c] = '0';
        Sink(grid, r + 1, c); Sink(grid, r - 1, c);
        Sink(grid, r, c + 1); Sink(grid, r, c - 1);
    }
}

[Problem(207)]
public sealed class CourseSchedule : ProblemTests<CourseSchedule>
{
    public bool Solve(int numCourses, int[][] prerequisites)
    {
        List<int>[] dependents = [.. Enumerable.Range(0, numCourses).Select(_ => new List<int>())];
        int[] indegree = new int[numCourses];

        foreach (int[] edge in prerequisites)
        {
            dependents[edge[1]].Add(edge[0]);
            indegree[edge[0]]++;
        }

        Queue<int> ready = new(Enumerable.Range(0, numCourses).Where(i => indegree[i] == 0));
        int taken = 0;
        while (ready.Count > 0)
        {
            int course = ready.Dequeue();
            taken++;
            foreach (int next in dependents[course])
                if (--indegree[next] == 0) ready.Enqueue(next);
        }
        return taken == numCourses;
    }
}

[Problem(70)]
public sealed class ClimbingStairs : ProblemTests<ClimbingStairs>
{
    public int Solve(int n)
    {
        int previous = 1, current = 1;
        for (int i = 2; i <= n; i++) (previous, current) = (current, previous + current);
        return current;
    }
}

[Problem(139)]
public sealed class WordBreak : ProblemTests<WordBreak>
{
    public bool Solve(string s, IList<string> wordDict)
    {
        HashSet<string> words = [.. wordDict];
        bool[] reachable = new bool[s.Length + 1];
        reachable[0] = true;

        for (int end = 1; end <= s.Length; end++)
            for (int start = 0; start < end; start++)
                if (reachable[start] && words.Contains(s[start..end])) { reachable[end] = true; break; }

        return reachable[s.Length];
    }
}

[Problem(198)]
public sealed class HouseRobber : ProblemTests<HouseRobber>
{
    public int Solve(int[] nums)
    {
        int skip = 0, take = 0;
        foreach (int value in nums) (skip, take) = (Math.Max(skip, take), skip + value);
        return Math.Max(skip, take);
    }
}

[Problem(300)]
public sealed class LongestIncreasingSubsequence : ProblemTests<LongestIncreasingSubsequence>
{
    public int Solve(int[] nums)
    {
        List<int> tails = [];
        foreach (int value in nums)
        {
            int index = tails.BinarySearch(value);
            if (index < 0) index = ~index;
            if (index == tails.Count) tails.Add(value); else tails[index] = value;
        }
        return tails.Count;
    }
}

[Problem(322)]
public sealed class CoinChange : ProblemTests<CoinChange>
{
    public int Solve(int[] coins, int amount)
    {
        int[] best = new int[amount + 1];
        Array.Fill(best, amount + 1);
        best[0] = 0;

        for (int value = 1; value <= amount; value++)
            foreach (int coin in coins)
                if (coin <= value) best[value] = Math.Min(best[value], best[value - coin] + 1);

        return best[amount] > amount ? -1 : best[amount];
    }
}

[Problem(5)]
public sealed class LongestPalindromicSubstring : ProblemTests<LongestPalindromicSubstring>
{
    public string Solve(string s)
    {
        if (s.Length == 0) return "";
        int start = 0, length = 1;

        void Expand(int lo, int hi)
        {
            while (lo >= 0 && hi < s.Length && s[lo] == s[hi]) { lo--; hi++; }
            if (hi - lo - 1 > length) { length = hi - lo - 1; start = lo + 1; }
        }

        for (int i = 0; i < s.Length; i++) { Expand(i, i); Expand(i, i + 1); }
        return s.Substring(start, length);
    }

    /// <summary>Any palindromic substring of s matching the known best length is accepted.</summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        string input = (string)args[0]!;
        if (actual is not string answer) return false;
        if (answer.Length != expected.GetString()!.Length) return false;
        if (!input.Contains(answer, StringComparison.Ordinal)) return false;

        for (int i = 0, j = answer.Length - 1; i < j; i++, j--)
            if (answer[i] != answer[j]) return false;

        return true;
    }
}
