using System.Text;
using System.Text.Json;

namespace LeetCodeLab.Verify.Reference;

[Problem(48)]
public sealed class RotateImage : ProblemTests<RotateImage>
{
    public void Solve(int[][] matrix)
    {
        int n = matrix.Length;
        for (int r = 0; r < n; r++)
            for (int c = r + 1; c < n; c++)
                (matrix[r][c], matrix[c][r]) = (matrix[c][r], matrix[r][c]);

        foreach (int[] row in matrix) Array.Reverse(row);
    }
}

[Problem(54)]
public sealed class SpiralMatrix : ProblemTests<SpiralMatrix>
{
    public IList<int> Solve(int[][] matrix)
    {
        List<int> order = [];
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int c = left; c <= right; c++) order.Add(matrix[top][c]);
            top++;

            for (int r = top; r <= bottom; r++) order.Add(matrix[r][right]);
            right--;

            if (top <= bottom)
            {
                for (int c = right; c >= left; c--) order.Add(matrix[bottom][c]);
                bottom--;
            }
            if (left <= right)
            {
                for (int r = bottom; r >= top; r--) order.Add(matrix[r][left]);
                left++;
            }
        }
        return order;
    }
}

[Problem(73)]
public sealed class SetMatrixZeroes : ProblemTests<SetMatrixZeroes>
{
    public void Solve(int[][] matrix)
    {
        HashSet<int> rows = [], cols = [];
        for (int r = 0; r < matrix.Length; r++)
            for (int c = 0; c < matrix[r].Length; c++)
                if (matrix[r][c] == 0) { rows.Add(r); cols.Add(c); }

        for (int r = 0; r < matrix.Length; r++)
            for (int c = 0; c < matrix[r].Length; c++)
                if (rows.Contains(r) || cols.Contains(c)) matrix[r][c] = 0;
    }
}

[Problem(209)]
public sealed class MinimumSizeSubarraySum : ProblemTests<MinimumSizeSubarraySum>
{
    public int Solve(int target, int[] nums)
    {
        int best = int.MaxValue, sum = 0, start = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= target)
            {
                best = Math.Min(best, i - start + 1);
                sum -= nums[start++];
            }
        }
        return best == int.MaxValue ? 0 : best;
    }
}

[Problem(567)]
public sealed class PermutationInString : ProblemTests<PermutationInString>
{
    public bool Solve(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        int[] need = new int[26], window = new int[26];
        foreach (char c in s1) need[c - 'a']++;

        for (int i = 0; i < s2.Length; i++)
        {
            window[s2[i] - 'a']++;
            if (i >= s1.Length) window[s2[i - s1.Length] - 'a']--;
            if (need.AsSpan().SequenceEqual(window)) return true;
        }
        return false;
    }
}

[Problem(76)]
public sealed class MinimumWindowSubstring : ProblemTests<MinimumWindowSubstring>
{
    public string Solve(string s, string t)
    {
        if (t.Length == 0 || s.Length < t.Length) return "";

        Dictionary<char, int> need = [];
        foreach (char c in t) need[c] = need.GetValueOrDefault(c) + 1;

        int missing = need.Count, start = 0, bestStart = 0, bestLength = int.MaxValue;
        Dictionary<char, int> window = [];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (need.ContainsKey(c))
            {
                window[c] = window.GetValueOrDefault(c) + 1;
                if (window[c] == need[c]) missing--;
            }

            while (missing == 0)
            {
                if (i - start + 1 < bestLength) { bestLength = i - start + 1; bestStart = start; }

                char leaving = s[start++];
                if (!need.ContainsKey(leaving)) continue;
                if (window[leaving] == need[leaving]) missing++;
                window[leaving]--;
            }
        }

        return bestLength == int.MaxValue ? "" : s.Substring(bestStart, bestLength);
    }
}

[Problem(84)]
public sealed class LargestRectangleInHistogram : ProblemTests<LargestRectangleInHistogram>
{
    public int Solve(int[] heights)
    {
        Stack<int> rising = new();
        int best = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            int current = i == heights.Length ? 0 : heights[i];
            while (rising.Count > 0 && heights[rising.Peek()] >= current)
            {
                int height = heights[rising.Pop()];
                int left = rising.Count == 0 ? -1 : rising.Peek();
                best = Math.Max(best, height * (i - left - 1));
            }
            rising.Push(i);
        }
        return best;
    }
}

[Problem(134)]
public sealed class GasStation : ProblemTests<GasStation>
{
    public int Solve(int[] gas, int[] cost)
    {
        int total = 0, tank = 0, start = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            int delta = gas[i] - cost[i];
            total += delta;
            tank += delta;
            if (tank < 0) { start = i + 1; tank = 0; }
        }
        return total < 0 ? -1 : start;
    }
}

[Problem(763)]
public sealed class PartitionLabels : ProblemTests<PartitionLabels>
{
    public IList<int> Solve(string s)
    {
        int[] last = new int[26];
        for (int i = 0; i < s.Length; i++) last[s[i] - 'a'] = i;

        List<int> sizes = [];
        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            end = Math.Max(end, last[s[i] - 'a']);
            if (i == end) { sizes.Add(end - start + 1); start = i + 1; }
        }
        return sizes;
    }
}

[Problem(435)]
public sealed class NonOverlappingIntervals : ProblemTests<NonOverlappingIntervals>
{
    public int Solve(int[][] intervals)
    {
        int[][] sorted = [.. intervals.OrderBy(interval => interval[1])];
        int kept = 0, lastEnd = int.MinValue;

        foreach (int[] interval in sorted)
            if (interval[0] >= lastEnd) { kept++; lastEnd = interval[1]; }

        return intervals.Length - kept;
    }
}

[Problem(50)]
public sealed class PowXN : ProblemTests<PowXN>
{
    public double Solve(double x, int n)
    {
        long exponent = n;
        if (exponent < 0) { x = 1 / x; exponent = -exponent; }

        double result = 1;
        while (exponent > 0)
        {
            if ((exponent & 1) == 1) result *= x;
            x *= x;
            exponent >>= 1;
        }
        return result;
    }
}

[Problem(643)]
public sealed class MaximumAverageSubarray : ProblemTests<MaximumAverageSubarray>
{
    public double Solve(int[] nums, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++) sum += nums[i];

        int best = sum;
        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            best = Math.Max(best, sum);
        }
        return best / (double)k;
    }
}

[Problem(162)]
public sealed class FindPeakElement : ProblemTests<FindPeakElement>
{
    public int Solve(int[] nums)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (nums[mid] < nums[mid + 1]) lo = mid + 1; else hi = mid;
        }
        return lo;
    }

    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int[] nums = (int[])args[0]!;
        if (actual is not int i || i < 0 || i >= nums.Length) return false;
        return (i == 0 || nums[i] > nums[i - 1])
            && (i == nums.Length - 1 || nums[i] > nums[i + 1]);
    }
}

[Problem(108)]
public sealed class SortedArrayToBst : ProblemTests<SortedArrayToBst>
{
    public TreeNode? Solve(int[] nums)
    {
        TreeNode? Build(int lo, int hi)
        {
            if (lo > hi) return null;
            int mid = lo + (hi - lo) / 2;
            return new TreeNode(nums[mid], Build(lo, mid - 1), Build(mid + 1, hi));
        }

        return Build(0, nums.Length - 1);
    }

    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int[] nums = (int[])args[0]!;
        TreeNode? root = actual as TreeNode;

        List<int> inorder = [];
        void Walk(TreeNode? node)
        {
            if (node is null) return;
            Walk(node.left);
            inorder.Add(node.val);
            Walk(node.right);
        }
        Walk(root);
        if (!inorder.SequenceEqual(nums)) return false;

        static int Height(TreeNode? node)
        {
            if (node is null) return 0;
            int left = Height(node.left), right = Height(node.right);
            if (left < 0 || right < 0 || Math.Abs(left - right) > 1) return -1;
            return 1 + Math.Max(left, right);
        }
        return Height(root) >= 0;
    }
}

[Problem(210)]
public sealed class CourseScheduleII : ProblemTests<CourseScheduleII>
{
    public int[] Solve(int numCourses, int[][] prerequisites)
    {
        List<int>[] dependents = [.. Enumerable.Range(0, numCourses).Select(_ => new List<int>())];
        int[] indegree = new int[numCourses];

        foreach (int[] edge in prerequisites)
        {
            dependents[edge[1]].Add(edge[0]);
            indegree[edge[0]]++;
        }

        Queue<int> ready = new(Enumerable.Range(0, numCourses).Where(i => indegree[i] == 0));
        List<int> order = [];

        while (ready.Count > 0)
        {
            int course = ready.Dequeue();
            order.Add(course);
            foreach (int next in dependents[course])
                if (--indegree[next] == 0) ready.Enqueue(next);
        }

        return order.Count == numCourses ? [.. order] : [];
    }

    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int numCourses = (int)args[0]!;
        int[][] prerequisites = (int[][])args[1]!;
        if (actual is not int[] order) return false;

        if (expected.GetArrayLength() == 0) return order.Length == 0;
        if (order.Length != numCourses) return false;

        int[] position = new int[numCourses];
        bool[] seen = new bool[numCourses];
        for (int i = 0; i < order.Length; i++)
        {
            int course = order[i];
            if (course < 0 || course >= numCourses || seen[course]) return false;
            seen[course] = true;
            position[course] = i;
        }

        foreach (int[] edge in prerequisites)
            if (position[edge[1]] > position[edge[0]]) return false;

        return true;
    }
}

[Problem(211, Target = typeof(WordDictionary))]
public sealed class WordDictionaryTests : ProblemTests<WordDictionaryTests>;

public class WordDictionary
{
    private readonly Dictionary<char, WordDictionary> _children = [];
    private bool _terminal;

    public void AddWord(string word)
    {
        WordDictionary node = this;
        foreach (char c in word)
        {
            if (!node._children.TryGetValue(c, out WordDictionary? next))
                node._children[c] = next = new WordDictionary();
            node = next;
        }
        node._terminal = true;
    }

    public bool Search(string word) => Match(word, 0);

    private bool Match(string pattern, int index)
    {
        if (index == pattern.Length) return _terminal;

        char c = pattern[index];
        if (c != '.')
            return _children.TryGetValue(c, out WordDictionary? next) && next.Match(pattern, index + 1);

        foreach (WordDictionary child in _children.Values)
            if (child.Match(pattern, index + 1)) return true;

        return false;
    }
}
