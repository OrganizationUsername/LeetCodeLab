namespace LeetCodeLab.Verify.Reference;

[Problem(146, Target = typeof(LRUCache))]
public sealed class LruCacheTests : ProblemTests<LruCacheTests>;

public class LRUCache
{
    private readonly int _capacity;
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> _map = [];
    private readonly LinkedList<(int Key, int Value)> _order = new();

    public LRUCache(int capacity) => _capacity = capacity;

    public int Get(int key)
    {
        if (!_map.TryGetValue(key, out LinkedListNode<(int Key, int Value)>? node)) return -1;
        _order.Remove(node);
        _order.AddFirst(node);
        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (_map.TryGetValue(key, out LinkedListNode<(int Key, int Value)>? existing))
        {
            _order.Remove(existing);
        }
        else if (_map.Count >= _capacity)
        {
            LinkedListNode<(int Key, int Value)> last = _order.Last!;
            _map.Remove(last.Value.Key);
            _order.RemoveLast();
        }
        _map[key] = _order.AddFirst((key, value));
    }
}

[Problem(155, Target = typeof(MinStack))]
public sealed class MinStackTests : ProblemTests<MinStackTests>;

public class MinStack
{
    private readonly Stack<int> _values = new();
    private readonly Stack<int> _mins = new();

    public void Push(int val)
    {
        _values.Push(val);
        _mins.Push(_mins.Count == 0 ? val : Math.Min(val, _mins.Peek()));
    }

    public void Pop() { _values.Pop(); _mins.Pop(); }
    public int Top() => _values.Peek();
    public int GetMin() => _mins.Peek();
}

[Problem(295, Target = typeof(MedianFinder))]
public sealed class MedianFinderTests : ProblemTests<MedianFinderTests>;

public class MedianFinder
{
    // _low is a max-heap over the smaller half; _high a min-heap over the larger half.
    private readonly PriorityQueue<int, int> _low = new();
    private readonly PriorityQueue<int, int> _high = new();

    public void AddNum(int num)
    {
        _low.Enqueue(num, -num);
        int promoted = _low.Dequeue();
        _high.Enqueue(promoted, promoted);

        if (_high.Count > _low.Count)
        {
            int demoted = _high.Dequeue();
            _low.Enqueue(demoted, -demoted);
        }
    }

    public double FindMedian() =>
        _low.Count > _high.Count ? _low.Peek() : (_low.Peek() + _high.Peek()) / 2.0;
}

[Problem(208, Target = typeof(Trie))]
public sealed class TrieTests : ProblemTests<TrieTests>;

public class Trie
{
    private readonly Dictionary<char, Trie> _children = [];
    private bool _terminal;

    public void Insert(string word)
    {
        Trie node = this;
        foreach (char c in word)
        {
            if (!node._children.TryGetValue(c, out Trie? next)) node._children[c] = next = new Trie();
            node = next;
        }
        node._terminal = true;
    }

    public bool Search(string word) => Walk(word) is { _terminal: true };

    public bool StartsWith(string prefix) => Walk(prefix) is not null;

    private Trie? Walk(string text)
    {
        Trie node = this;
        foreach (char c in text)
        {
            if (!node._children.TryGetValue(c, out Trie? next)) return null;
            node = next;
        }
        return node;
    }
}

[Problem(703, Target = typeof(KthLargest))]
public sealed class KthLargestTests : ProblemTests<KthLargestTests>;

public class KthLargest
{
    private readonly int _k;
    private readonly PriorityQueue<int, int> _smallest = new();

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        foreach (int value in nums) Add(value);
    }

    public int Add(int val)
    {
        _smallest.Enqueue(val, val);
        while (_smallest.Count > _k) _smallest.Dequeue();
        return _smallest.Peek();
    }
}
