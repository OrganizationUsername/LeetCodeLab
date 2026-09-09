namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the greedy, string and trie batch.
// They exist only to prove the case files.

[Problem(122)]
public sealed class BestTimeToBuyAndSellStockII : ProblemTests<BestTimeToBuyAndSellStockII>
{
    public int Solve(int[] prices)
    {
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
            if (prices[i] > prices[i - 1]) profit += prices[i] - prices[i - 1];
        return profit;
    }
}

[Problem(605)]
public sealed class CanPlaceFlowers : ProblemTests<CanPlaceFlowers>
{
    public bool Solve(int[] flowerbed, int n)
    {
        int planted = 0;
        for (int i = 0; i < flowerbed.Length && planted < n; i++)
        {
            if (flowerbed[i] != 0) continue;

            bool leftFree = i == 0 || flowerbed[i - 1] == 0;
            bool rightFree = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
            if (!leftFree || !rightFree) continue;

            flowerbed[i] = 1;      // write it, so the next plot sees it
            planted++;
        }
        return planted >= n;
    }
}

[Problem(455)]
public sealed class AssignCookies : ProblemTests<AssignCookies>
{
    public int Solve(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int child = 0, cookie = 0;
        while (child < g.Length && cookie < s.Length)
        {
            if (s[cookie] >= g[child]) child++;
            cookie++;
        }
        return child;
    }
}

[Problem(860)]
public sealed class LemonadeChange : ProblemTests<LemonadeChange>
{
    public bool Solve(int[] bills)
    {
        int fives = 0, tens = 0;
        foreach (int bill in bills)
        {
            if (bill == 5) fives++;
            else if (bill == 10)
            {
                if (fives == 0) return false;
                fives--;
                tens++;
            }
            else if (tens > 0 && fives > 0) { tens--; fives--; }   // prefer the ten
            else if (fives >= 3) fives -= 3;
            else return false;
        }
        return true;
    }
}

[Problem(678)]
public sealed class ValidParenthesisString : ProblemTests<ValidParenthesisString>
{
    public bool Solve(string s)
    {
        int low = 0, high = 0;
        foreach (char c in s)
        {
            if (c == '(') { low++; high++; }
            else if (c == ')') { low--; high--; }
            else { low--; high++; }

            if (high < 0) return false;
            if (low < 0) low = 0;
        }
        return low == 0;
    }
}

[Problem(8)]
public sealed class StringToInteger : ProblemTests<StringToInteger>
{
    public int Solve(string s)
    {
        int i = 0;
        while (i < s.Length && s[i] == ' ') i++;
        if (i == s.Length) return 0;

        int sign = 1;
        if (s[i] == '+' || s[i] == '-')
        {
            if (s[i] == '-') sign = -1;
            i++;
        }

        long value = 0;
        while (i < s.Length && char.IsAsciiDigit(s[i]))
        {
            value = value * 10 + (s[i] - '0');
            if (sign == 1 && value > int.MaxValue) return int.MaxValue;
            if (sign == -1 && -value < int.MinValue) return int.MinValue;
            i++;
        }
        return (int)(sign * value);
    }
}

[Problem(43)]
public sealed class MultiplyStrings : ProblemTests<MultiplyStrings>
{
    public string Solve(string num1, string num2)
    {
        int n = num1.Length, m = num2.Length;
        int[] digits = new int[n + m];

        for (int i = n - 1; i >= 0; i--)
            for (int j = m - 1; j >= 0; j--)
                digits[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');

        for (int k = n + m - 1; k > 0; k--)
        {
            digits[k - 1] += digits[k] / 10;
            digits[k] %= 10;
        }

        int start = 0;
        while (start < digits.Length - 1 && digits[start] == 0) start++;
        return string.Concat(digits.Skip(start));
    }
}

[Problem(151)]
public sealed class ReverseWordsInAString : ProblemTests<ReverseWordsInAString>
{
    public string Solve(string s)
        => string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
}

[Problem(443)]
public sealed class StringCompression : ProblemTests<StringCompression>
{
    public int Solve(char[] chars)
    {
        int write = 0, read = 0;

        while (read < chars.Length)
        {
            char current = chars[read];
            int runLength = 0;
            while (read < chars.Length && chars[read] == current) { read++; runLength++; }

            chars[write++] = current;
            if (runLength > 1)
                foreach (char digit in runLength.ToString())
                    chars[write++] = digit;
        }
        return write;
    }
}

[Problem(205)]
public sealed class IsomorphicStrings : ProblemTests<IsomorphicStrings>
{
    public bool Solve(string s, string t)
    {
        Dictionary<char, char> forward = [], backward = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (forward.TryGetValue(s[i], out char mapped) && mapped != t[i]) return false;
            if (backward.TryGetValue(t[i], out char origin) && origin != s[i]) return false;
            forward[s[i]] = t[i];
            backward[t[i]] = s[i];
        }
        return true;
    }
}

[Problem(212)]
public sealed class WordSearchII : ProblemTests<WordSearchII>
{
    private sealed class Node
    {
        public Dictionary<char, Node> Children { get; } = [];
        public string? Word { get; set; }
    }

    public IList<string> Solve(char[][] board, string[] words)
    {
        Node root = new();
        foreach (string word in words)
        {
            Node node = root;
            foreach (char c in word)
            {
                if (!node.Children.TryGetValue(c, out Node? child))
                    node.Children[c] = child = new Node();
                node = child;
            }
            node.Word = word;
        }

        List<string> found = [];
        int rows = board.Length, cols = board[0].Length;

        void Search(int r, int c, Node node)
        {
            if (r < 0 || r >= rows || c < 0 || c >= cols) return;

            char letter = board[r][c];
            if (letter == '#' || !node.Children.TryGetValue(letter, out Node? next)) return;

            if (next.Word is not null) { found.Add(next.Word); next.Word = null; }

            board[r][c] = '#';
            Search(r + 1, c, next);
            Search(r - 1, c, next);
            Search(r, c + 1, next);
            Search(r, c - 1, next);
            board[r][c] = letter;
        }

        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                Search(r, c, root);

        return found;
    }
}

[Problem(421)]
public sealed class MaximumXor : ProblemTests<MaximumXor>
{
    public int Solve(int[] nums)
    {
        int best = 0, mask = 0;

        for (int bit = 30; bit >= 0; bit--)
        {
            mask |= 1 << bit;
            HashSet<int> prefixes = [];
            foreach (int value in nums) prefixes.Add(value & mask);

            int candidate = best | (1 << bit);
            foreach (int prefix in prefixes)
                if (prefixes.Contains(prefix ^ candidate)) { best = candidate; break; }
        }
        return best;
    }
}

[Problem(1268)]
public sealed class SearchSuggestionsSystem : ProblemTests<SearchSuggestionsSystem>
{
    public IList<IList<string>> Solve(string[] products, string searchWord)
    {
        string[] sorted = [.. products.OrderBy(p => p, StringComparer.Ordinal)];
        List<IList<string>> result = [];

        for (int length = 1; length <= searchWord.Length; length++)
        {
            string prefix = searchWord[..length];
            List<string> suggestions = [];

            foreach (string product in sorted)
            {
                if (!product.StartsWith(prefix, StringComparison.Ordinal)) continue;
                suggestions.Add(product);
                if (suggestions.Count == 3) break;
            }
            result.Add(suggestions);
        }
        return result;
    }
}

[Problem(677, Target = typeof(MapSum))]
public sealed class MapSumPairsTests : ProblemTests<MapSumPairsTests>;

public class MapSum
{
    private readonly Dictionary<string, int> _values = [];
    private readonly Dictionary<string, int> _prefixTotals = [];

    public void Insert(string key, int val)
    {
        // Apply the DIFFERENCE, so re-inserting a key replaces rather than accumulates.
        int delta = val - _values.GetValueOrDefault(key);
        _values[key] = val;

        for (int i = 1; i <= key.Length; i++)
        {
            string prefix = key[..i];
            _prefixTotals[prefix] = _prefixTotals.GetValueOrDefault(prefix) + delta;
        }
    }

    public int Sum(string prefix) => _prefixTotals.GetValueOrDefault(prefix);
}
