using System.Text;

namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the union-find, monotonic-stack, prefix-sum, trie,
// plane-geometry and simulation problems. They exist only to prove the case files.

[Problem(684)]
public sealed class RedundantConnection : ProblemTests<RedundantConnection>
{
    public int[] Solve(int[][] edges)
    {
        int[] parent = new int[edges.Length + 1];
        for (int i = 0; i < parent.Length; i++) parent[i] = i;

        int Find(int x)
        {
            while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; }
            return x;
        }

        foreach (int[] edge in edges)
        {
            int a = Find(edge[0]), b = Find(edge[1]);
            if (a == b) return edge;
            parent[a] = b;
        }
        return [];
    }
}

[Problem(990)]
public sealed class SatisfiabilityOfEqualityEquations : ProblemTests<SatisfiabilityOfEqualityEquations>
{
    public bool Solve(string[] equations)
    {
        int[] parent = new int[26];
        for (int i = 0; i < 26; i++) parent[i] = i;

        int Find(int x)
        {
            while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; }
            return x;
        }

        foreach (string equation in equations)
            if (equation[1] == '=') parent[Find(equation[0] - 'a')] = Find(equation[3] - 'a');

        foreach (string equation in equations)
            if (equation[1] == '!' && Find(equation[0] - 'a') == Find(equation[3] - 'a')) return false;

        return true;
    }
}

[Problem(1319)]
public sealed class MakeNetworkConnected : ProblemTests<MakeNetworkConnected>
{
    public int Solve(int n, int[][] connections)
    {
        if (connections.Length < n - 1) return -1;

        int[] parent = new int[n];
        for (int i = 0; i < n; i++) parent[i] = i;

        int Find(int x)
        {
            while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; }
            return x;
        }

        int components = n;
        foreach (int[] cable in connections)
        {
            int a = Find(cable[0]), b = Find(cable[1]);
            if (a != b) { parent[a] = b; components--; }
        }
        return components - 1;
    }
}

[Problem(496)]
public sealed class NextGreaterElementI : ProblemTests<NextGreaterElementI>
{
    public int[] Solve(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> next = [];
        Stack<int> waiting = new();

        foreach (int value in nums2)
        {
            while (waiting.Count > 0 && waiting.Peek() < value) next[waiting.Pop()] = value;
            waiting.Push(value);
        }

        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
            result[i] = next.TryGetValue(nums1[i], out int greater) ? greater : -1;
        return result;
    }
}

[Problem(503)]
public sealed class NextGreaterElementII : ProblemTests<NextGreaterElementII>
{
    public int[] Solve(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);

        Stack<int> waiting = new();
        for (int i = 0; i < 2 * n; i++)
        {
            int value = nums[i % n];
            while (waiting.Count > 0 && nums[waiting.Peek()] < value) result[waiting.Pop()] = value;
            if (i < n) waiting.Push(i);
        }
        return result;
    }
}

[Problem(239)]
public sealed class SlidingWindowMaximum : ProblemTests<SlidingWindowMaximum>
{
    public int[] Solve(int[] nums, int k)
    {
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        int[] window = new int[n];          // indices, values decreasing front to back
        int head = 0, tail = 0;

        for (int i = 0; i < n; i++)
        {
            while (tail > head && nums[window[tail - 1]] <= nums[i]) tail--;
            window[tail++] = i;
            if (window[head] <= i - k) head++;
            if (i >= k - 1) result[i - k + 1] = nums[window[head]];
        }
        return result;
    }
}

[Problem(560)]
public sealed class SubarraySumEqualsK : ProblemTests<SubarraySumEqualsK>
{
    public int Solve(int[] nums, int k)
    {
        Dictionary<int, int> seen = new() { [0] = 1 };
        int running = 0, count = 0;

        foreach (int value in nums)
        {
            running += value;
            if (seen.TryGetValue(running - k, out int hits)) count += hits;
            seen[running] = seen.GetValueOrDefault(running) + 1;
        }
        return count;
    }
}

[Problem(974)]
public sealed class SubarraySumsDivisibleByK : ProblemTests<SubarraySumsDivisibleByK>
{
    public int Solve(int[] nums, int k)
    {
        int[] counts = new int[k];
        counts[0] = 1;
        int remainder = 0, total = 0;

        foreach (int value in nums)
        {
            remainder = ((remainder + value) % k + k) % k;
            total += counts[remainder];
            counts[remainder]++;
        }
        return total;
    }
}

[Problem(1109)]
public sealed class CorporateFlightBookings : ProblemTests<CorporateFlightBookings>
{
    public int[] Solve(int[][] bookings, int n)
    {
        int[] delta = new int[n + 1];
        foreach (int[] booking in bookings)
        {
            delta[booking[0] - 1] += booking[2];
            delta[booking[1]] -= booking[2];
        }

        int[] result = new int[n];
        int running = 0;
        for (int i = 0; i < n; i++) { running += delta[i]; result[i] = running; }
        return result;
    }
}

[Problem(648)]
public sealed class ReplaceWords : ProblemTests<ReplaceWords>
{
    private sealed class Node
    {
        public Dictionary<char, Node> Children { get; } = [];
        public bool IsRoot { get; set; }
    }

    public string Solve(string[] dictionary, string sentence)
    {
        Node trie = new();
        foreach (string root in dictionary)
        {
            Node node = trie;
            foreach (char c in root)
            {
                if (!node.Children.TryGetValue(c, out Node? child))
                    node.Children[c] = child = new Node();
                node = child;
            }
            node.IsRoot = true;
        }

        string[] words = sentence.Split(' ');
        for (int w = 0; w < words.Length; w++)
        {
            Node node = trie;
            for (int i = 0; i < words[w].Length; i++)
            {
                if (!node.Children.TryGetValue(words[w][i], out Node? child)) break;
                node = child;
                if (node.IsRoot) { words[w] = words[w][..(i + 1)]; break; }
            }
        }
        return string.Join(' ', words);
    }
}

[Problem(720)]
public sealed class LongestWordInDictionary : ProblemTests<LongestWordInDictionary>
{
    public string Solve(string[] words)
    {
        string[] sorted = [.. words.OrderBy(w => w, StringComparer.Ordinal)];
        HashSet<string> buildable = [];
        string best = "";

        foreach (string word in sorted)
        {
            if (word.Length != 1 && !buildable.Contains(word[..^1])) continue;
            buildable.Add(word);
            if (word.Length > best.Length) best = word;
        }
        return best;
    }
}

[Problem(149)]
public sealed class MaxPointsOnALine : ProblemTests<MaxPointsOnALine>
{
    public int Solve(int[][] points)
    {
        int n = points.Length;
        if (n <= 2) return n;

        int best = 2;
        for (int i = 0; i < n; i++)
        {
            Dictionary<(int, int), int> directions = [];
            for (int j = i + 1; j < n; j++)
            {
                int dx = points[j][0] - points[i][0];
                int dy = points[j][1] - points[i][1];

                int divisor = Gcd(Math.Abs(dx), Math.Abs(dy));
                if (divisor != 0) { dx /= divisor; dy /= divisor; }
                if (dx < 0 || (dx == 0 && dy < 0)) { dx = -dx; dy = -dy; }

                (int, int) key = (dx, dy);
                directions[key] = directions.GetValueOrDefault(key) + 1;
                best = Math.Max(best, directions[key] + 1);
            }
        }
        return best;
    }

    private static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);
}

[Problem(836)]
public sealed class RectangleOverlap : ProblemTests<RectangleOverlap>
{
    public bool Solve(int[] rec1, int[] rec2)
        => Math.Max(rec1[0], rec2[0]) < Math.Min(rec1[2], rec2[2])
        && Math.Max(rec1[1], rec2[1]) < Math.Min(rec1[3], rec2[3]);
}

[Problem(289)]
public sealed class GameOfLife : ProblemTests<GameOfLife>
{
    public void Solve(int[][] board)
    {
        int rows = board.Length, cols = board[0].Length;

        // Bit 0 holds the current state, bit 1 the next one, so neighbours still read the old board.
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
            {
                int live = 0;
                for (int dr = -1; dr <= 1; dr++)
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        if (dr == 0 && dc == 0) continue;
                        int nr = r + dr, nc = c + dc;
                        if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && (board[nr][nc] & 1) == 1)
                            live++;
                    }

                bool alive = (board[r][c] & 1) == 1;
                if (alive ? live is 2 or 3 : live == 3) board[r][c] |= 2;
            }

        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                board[r][c] >>= 1;
    }
}

[Problem(68)]
public sealed class TextJustification : ProblemTests<TextJustification>
{
    public IList<string> Solve(string[] words, int maxWidth)
    {
        List<string> lines = [];
        int i = 0;

        while (i < words.Length)
        {
            int j = i, letters = 0;
            while (j < words.Length && letters + words[j].Length + (j - i) <= maxWidth)
                letters += words[j++].Length;

            int gaps = j - i - 1;
            StringBuilder line = new();

            if (j == words.Length || gaps == 0)
            {
                line.Append(string.Join(' ', words[i..j]));
                line.Append(' ', maxWidth - line.Length);
            }
            else
            {
                int spaces = maxWidth - letters;
                int each = spaces / gaps, extra = spaces % gaps;
                for (int w = i; w < j; w++)
                {
                    line.Append(words[w]);
                    if (w < j - 1) line.Append(' ', each + (w - i < extra ? 1 : 0));
                }
            }

            lines.Add(line.ToString());
            i = j;
        }
        return lines;
    }
}
