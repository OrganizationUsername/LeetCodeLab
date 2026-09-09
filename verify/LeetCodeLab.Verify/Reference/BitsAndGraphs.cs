namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the bit-manipulation and graph batch.
// They exist only to prove the case files.

[Problem(190)]
public sealed class ReverseBits : ProblemTests<ReverseBits>
{
    public uint Solve(uint n)
    {
        uint result = 0;
        // A fixed 32 iterations, so leading zeros still travel to the top.
        for (int i = 0; i < 32; i++) { result = (result << 1) | (n & 1); n >>= 1; }
        return result;
    }
}

[Problem(231)]
public sealed class PowerOfTwo : ProblemTests<PowerOfTwo>
{
    public bool Solve(int n) => n > 0 && (n & (n - 1)) == 0;
}

[Problem(371)]
public sealed class SumOfTwoIntegers : ProblemTests<SumOfTwoIntegers>
{
    public int Solve(int a, int b)
    {
        while (b != 0)
        {
            int carry = (int)((uint)(a & b) << 1);
            a ^= b;
            b = carry;
        }
        return a;
    }
}

[Problem(137)]
public sealed class SingleNumberII : ProblemTests<SingleNumberII>
{
    public int Solve(int[] nums)
    {
        int ones = 0, twos = 0;
        foreach (int value in nums)
        {
            ones = (ones ^ value) & ~twos;
            twos = (twos ^ value) & ~ones;
        }
        return ones;
    }
}

[Problem(260)]
public sealed class SingleNumberIII : ProblemTests<SingleNumberIII>
{
    public int[] Solve(int[] nums)
    {
        int combined = 0;
        foreach (int value in nums) combined ^= value;

        int lowestDifferingBit = combined & -combined;
        int first = 0, second = 0;
        foreach (int value in nums)
        {
            if ((value & lowestDifferingBit) != 0) first ^= value;
            else second ^= value;
        }
        return [first, second];
    }
}

[Problem(201)]
public sealed class BitwiseAndOfNumbersRange : ProblemTests<BitwiseAndOfNumbersRange>
{
    public int Solve(int left, int right)
    {
        int shift = 0;
        while (left != right) { left >>= 1; right >>= 1; shift++; }
        return left << shift;
    }
}

[Problem(785)]
public sealed class IsGraphBipartite : ProblemTests<IsGraphBipartite>
{
    public bool Solve(int[][] graph)
    {
        int n = graph.Length;
        int[] colour = new int[n];
        Array.Fill(colour, -1);

        for (int start = 0; start < n; start++)
        {
            if (colour[start] != -1) continue;
            colour[start] = 0;

            Queue<int> queue = new();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                foreach (int next in graph[node])
                {
                    if (colour[next] == colour[node]) return false;
                    if (colour[next] != -1) continue;
                    colour[next] = 1 - colour[node];
                    queue.Enqueue(next);
                }
            }
        }
        return true;
    }
}

[Problem(743)]
public sealed class NetworkDelayTime : ProblemTests<NetworkDelayTime>
{
    public int Solve(int[][] times, int n, int k)
    {
        List<(int To, int Weight)>[] adjacency = new List<(int, int)>[n + 1];
        for (int i = 1; i <= n; i++) adjacency[i] = [];
        foreach (int[] edge in times) adjacency[edge[0]].Add((edge[1], edge[2]));

        int[] best = new int[n + 1];
        Array.Fill(best, int.MaxValue);
        best[k] = 0;

        PriorityQueue<int, int> queue = new();
        queue.Enqueue(k, 0);
        while (queue.TryDequeue(out int node, out int time))
        {
            if (time > best[node]) continue;
            foreach ((int to, int weight) in adjacency[node])
                if (time + weight < best[to])
                {
                    best[to] = time + weight;
                    queue.Enqueue(to, best[to]);
                }
        }

        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (best[i] == int.MaxValue) return -1;
            answer = Math.Max(answer, best[i]);
        }
        return answer;
    }
}

[Problem(802)]
public sealed class FindEventualSafeStates : ProblemTests<FindEventualSafeStates>
{
    public int[] Solve(int[][] graph)
    {
        int n = graph.Length;
        // 0 unvisited, 1 on the current stack, 2 proven safe, 3 proven unsafe.
        int[] state = new int[n];

        bool Safe(int node)
        {
            if (state[node] == 2) return true;
            if (state[node] is 1 or 3) return false;

            state[node] = 1;
            foreach (int next in graph[node])
                if (!Safe(next)) { state[node] = 3; return false; }

            state[node] = 2;
            return true;
        }

        List<int> result = [];
        for (int i = 0; i < n; i++) if (Safe(i)) result.Add(i);
        return [.. result];
    }
}

[Problem(1091)]
public sealed class ShortestPathInBinaryMatrix : ProblemTests<ShortestPathInBinaryMatrix>
{
    public int Solve(int[][] grid)
    {
        int n = grid.Length;
        if (grid[0][0] != 0 || grid[n - 1][n - 1] != 0) return -1;

        Queue<(int Row, int Col, int Length)> queue = new();
        queue.Enqueue((0, 0, 1));
        grid[0][0] = 1;

        while (queue.Count > 0)
        {
            (int row, int col, int length) = queue.Dequeue();
            if (row == n - 1 && col == n - 1) return length;

            for (int dr = -1; dr <= 1; dr++)
                for (int dc = -1; dc <= 1; dc++)
                {
                    if (dr == 0 && dc == 0) continue;
                    int nr = row + dr, nc = col + dc;
                    if (nr < 0 || nr >= n || nc < 0 || nc >= n || grid[nr][nc] != 0) continue;
                    grid[nr][nc] = 1;
                    queue.Enqueue((nr, nc, length + 1));
                }
        }
        return -1;
    }
}

[Problem(841)]
public sealed class KeysAndRooms : ProblemTests<KeysAndRooms>
{
    public bool Solve(int[][] rooms)
    {
        bool[] open = new bool[rooms.Length];
        open[0] = true;
        int opened = 1;

        Stack<int> stack = new();
        stack.Push(0);
        while (stack.Count > 0)
            foreach (int key in rooms[stack.Pop()])
                if (!open[key]) { open[key] = true; opened++; stack.Push(key); }

        return opened == rooms.Length;
    }
}

[Problem(1584)]
public sealed class MinCostToConnectAllPoints : ProblemTests<MinCostToConnectAllPoints>
{
    public int Solve(int[][] points)
    {
        int n = points.Length;
        int[] best = new int[n];
        bool[] inTree = new bool[n];
        Array.Fill(best, int.MaxValue);
        best[0] = 0;

        int total = 0;
        for (int step = 0; step < n; step++)
        {
            int pick = -1;
            for (int i = 0; i < n; i++)
                if (!inTree[i] && (pick == -1 || best[i] < best[pick])) pick = i;

            inTree[pick] = true;
            total += best[pick];

            for (int i = 0; i < n; i++)
            {
                if (inTree[i]) continue;
                int distance = Math.Abs(points[i][0] - points[pick][0])
                             + Math.Abs(points[i][1] - points[pick][1]);
                if (distance < best[i]) best[i] = distance;
            }
        }
        return total;
    }
}
