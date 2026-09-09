using System.Text;
using System.Text.Json;

namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the heap, interval and stack batch.
// They exist only to prove the case files.

[Problem(621)]
public sealed class TaskScheduler : ProblemTests<TaskScheduler>
{
    public int Solve(char[] tasks, int n)
    {
        int[] counts = new int[26];
        foreach (char task in tasks) counts[task - 'A']++;

        int max = counts.Max();
        int ties = counts.Count(c => c == max);
        return Math.Max(tasks.Length, (max - 1) * (n + 1) + ties);
    }
}

[Problem(378)]
public sealed class KthSmallestInSortedMatrix : ProblemTests<KthSmallestInSortedMatrix>
{
    public int Solve(int[][] matrix, int k)
    {
        int n = matrix.Length;
        int lo = matrix[0][0], hi = matrix[n - 1][n - 1];

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;

            // Count entries <= mid by walking the staircase; col only ever decreases.
            int count = 0, col = n - 1;
            for (int row = 0; row < n; row++)
            {
                while (col >= 0 && matrix[row][col] > mid) col--;
                count += col + 1;
            }

            if (count < k) lo = mid + 1; else hi = mid;
        }
        return lo;
    }
}

[Problem(692)]
public sealed class TopKFrequentWords : ProblemTests<TopKFrequentWords>
{
    public IList<string> Solve(string[] words, int k)
    {
        Dictionary<string, int> counts = [];
        foreach (string word in words) counts[word] = counts.GetValueOrDefault(word) + 1;

        return [.. counts
            .OrderByDescending(entry => entry.Value)
            .ThenBy(entry => entry.Key, StringComparer.Ordinal)
            .Take(k)
            .Select(entry => entry.Key)];
    }
}

[Problem(1642)]
public sealed class FurthestBuilding : ProblemTests<FurthestBuilding>
{
    public int Solve(int[] heights, int bricks, int ladders)
    {
        // Ladders go to every climb on sight; the smallest is reclaimed and paid in bricks.
        PriorityQueue<int, int> ladderClimbs = new();

        for (int i = 0; i + 1 < heights.Length; i++)
        {
            int climb = heights[i + 1] - heights[i];
            if (climb <= 0) continue;

            ladderClimbs.Enqueue(climb, climb);
            if (ladderClimbs.Count <= ladders) continue;

            bricks -= ladderClimbs.Dequeue();
            if (bricks < 0) return i;
        }
        return heights.Length - 1;
    }
}

[Problem(767)]
public sealed class ReorganizeString : ProblemTests<ReorganizeString>
{
    public string Solve(string s)
    {
        int[] counts = new int[26];
        foreach (char c in s) counts[c - 'a']++;

        int best = 0;
        for (int i = 1; i < 26; i++) if (counts[i] > counts[best]) best = i;
        if (counts[best] > (s.Length + 1) / 2) return "";

        char[] result = new char[s.Length];
        int at = 0;

        void Place(int letter)
        {
            while (counts[letter] > 0)
            {
                if (at >= s.Length) at = 1;      // fall back to the odd slots
                result[at] = (char)('a' + letter);
                at += 2;
                counts[letter]--;
            }
        }

        Place(best);
        for (int i = 0; i < 26; i++) if (i != best) Place(i);
        return new string(result);
    }

    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        string input = (string)args[0]!;
        string want = expected.GetString() ?? "";
        string got = actual as string ?? "";

        if (want.Length == 0) return got.Length == 0;
        if (got.Length != input.Length) return false;
        for (int i = 1; i < got.Length; i++)
            if (got[i] == got[i - 1]) return false;

        return string.Concat(got.OrderBy(c => c)) == string.Concat(input.OrderBy(c => c));
    }
}

[Problem(452)]
public sealed class MinimumArrows : ProblemTests<MinimumArrows>
{
    public int Solve(int[][] points)
    {
        // CompareTo, not subtraction: the coordinates here span the whole int range.
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        int arrows = 1;
        long last = points[0][1];
        for (int i = 1; i < points.Length; i++)
            if (points[i][0] > last) { arrows++; last = points[i][1]; }

        return arrows;
    }
}

[Problem(986)]
public sealed class IntervalListIntersections : ProblemTests<IntervalListIntersections>
{
    public int[][] Solve(int[][] firstList, int[][] secondList)
    {
        List<int[]> result = [];
        int i = 0, j = 0;

        while (i < firstList.Length && j < secondList.Length)
        {
            int start = Math.Max(firstList[i][0], secondList[j][0]);
            int end = Math.Min(firstList[i][1], secondList[j][1]);
            if (start <= end) result.Add([start, end]);

            if (firstList[i][1] < secondList[j][1]) i++; else j++;
        }
        return [.. result];
    }
}

[Problem(1094)]
public sealed class CarPooling : ProblemTests<CarPooling>
{
    public bool Solve(int[][] trips, int capacity)
    {
        int[] delta = new int[1002];
        foreach (int[] trip in trips)
        {
            delta[trip[1]] += trip[0];
            delta[trip[2]] -= trip[0];      // they get off AT the drop point
        }

        int load = 0;
        foreach (int change in delta)
        {
            load += change;
            if (load > capacity) return false;
        }
        return true;
    }
}

[Problem(646)]
public sealed class MaximumLengthOfPairChain : ProblemTests<MaximumLengthOfPairChain>
{
    public int Solve(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));

        int count = 0;
        long lastEnd = long.MinValue;
        foreach (int[] pair in pairs)
            if (pair[0] > lastEnd) { count++; lastEnd = pair[1]; }

        return count;
    }
}

[Problem(1288)]
public sealed class RemoveCoveredIntervals : ProblemTests<RemoveCoveredIntervals>
{
    public int Solve(int[][] intervals)
    {
        // Start ascending, and on a tie the LONGER interval first so it covers the shorter.
        Array.Sort(intervals, (a, b) =>
            a[0] != b[0] ? a[0].CompareTo(b[0]) : b[1].CompareTo(a[1]));

        int remaining = 0, maxEnd = int.MinValue;
        foreach (int[] interval in intervals)
            if (interval[1] > maxEnd) { remaining++; maxEnd = interval[1]; }

        return remaining;
    }
}

[Problem(71)]
public sealed class SimplifyPath : ProblemTests<SimplifyPath>
{
    public string Solve(string path)
    {
        Stack<string> parts = new();
        foreach (string part in path.Split('/'))
        {
            if (part.Length == 0 || part == ".") continue;
            if (part == "..") { if (parts.Count > 0) parts.Pop(); }
            else parts.Push(part);
        }
        return "/" + string.Join("/", parts.Reverse());
    }
}

[Problem(394)]
public sealed class DecodeString : ProblemTests<DecodeString>
{
    public string Solve(string s)
    {
        Stack<StringBuilder> texts = new();
        Stack<int> counts = new();
        StringBuilder current = new();
        int number = 0;

        foreach (char c in s)
        {
            if (char.IsDigit(c)) number = number * 10 + (c - '0');
            else if (c == '[')
            {
                counts.Push(number);
                number = 0;
                texts.Push(current);
                current = new StringBuilder();
            }
            else if (c == ']')
            {
                StringBuilder outer = texts.Pop();
                int repeat = counts.Pop();
                for (int i = 0; i < repeat; i++) outer.Append(current);
                current = outer;
            }
            else current.Append(c);
        }
        return current.ToString();
    }
}

[Problem(735)]
public sealed class AsteroidCollision : ProblemTests<AsteroidCollision>
{
    public int[] Solve(int[] asteroids)
    {
        List<int> survivors = [];

        foreach (int asteroid in asteroids)
        {
            bool alive = true;
            while (alive && asteroid < 0 && survivors.Count > 0 && survivors[^1] > 0)
            {
                if (survivors[^1] < -asteroid) survivors.RemoveAt(survivors.Count - 1);
                else
                {
                    if (survivors[^1] == -asteroid) survivors.RemoveAt(survivors.Count - 1);
                    alive = false;
                }
            }
            if (alive) survivors.Add(asteroid);
        }
        return [.. survivors];
    }
}

[Problem(946)]
public sealed class ValidateStackSequences : ProblemTests<ValidateStackSequences>
{
    public bool Solve(int[] pushed, int[] popped)
    {
        Stack<int> stack = new();
        int next = 0;

        foreach (int value in pushed)
        {
            stack.Push(value);
            while (stack.Count > 0 && next < popped.Length && stack.Peek() == popped[next])
            {
                stack.Pop();
                next++;
            }
        }
        return stack.Count == 0;
    }
}

[Problem(402)]
public sealed class RemoveKDigits : ProblemTests<RemoveKDigits>
{
    public string Solve(string num, int k)
    {
        List<char> kept = [];
        foreach (char digit in num)
        {
            while (k > 0 && kept.Count > 0 && kept[^1] > digit)
            {
                kept.RemoveAt(kept.Count - 1);
                k--;
            }
            kept.Add(digit);
        }

        while (k-- > 0 && kept.Count > 0) kept.RemoveAt(kept.Count - 1);

        int start = 0;
        while (start < kept.Count - 1 && kept[start] == '0') start++;

        string result = new([.. kept.Skip(start)]);
        return result.Length == 0 ? "0" : result;
    }
}
