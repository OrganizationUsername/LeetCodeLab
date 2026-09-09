namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  146. LRU Cache                                                     [Medium]
//  https://leetcode.com/problems/lru-cache/
// ----------------------------------------------------------------------------
//  Build a fixed-capacity cache with least-recently-used eviction. Get
//  returns the value or -1 if absent. Put inserts or updates. Both count as a
//  use. When Put would exceed capacity, evict the least recently used key
//  first. Both operations must be O(1) on average.
//
//  Examples
//    LRUCache, put, put, get, put, get, put, get, get, get
//      with [[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]
//      ->   [null,null,null,1,null,-1,null,-1,3,4]
//
//  Constraints
//    1 <= capacity <= 3000
//    up to 2*10^5 calls
//
//  Hints (read only as many as you need)
//    1. A Dictionary gives O(1) lookup but no idea of recency; a list gives
//       ordering but O(n) removal. You need both at once.
//    2. Combine a Dictionary with a doubly linked list, where the dictionary
//       maps a key to its list NODE.
//    3. Holding the node is what makes unlinking O(1). Move a node to the
//       front on every access; evict from the back. LinkedList<T> and
//       LinkedListNode<T> in the BCL are doubly linked already.
//
//  Aim for O(1) per operation
// ============================================================================
[Problem(146, Target = typeof(LRUCache))]
public sealed class LruCacheTests : ProblemTests<LruCacheTests>;

public class LRUCache
{
    public LRUCache(int capacity)
    {
        throw new NotImplementedException();
    }

    public int Get(int key)
    {
        throw new NotImplementedException();
    }

    public void Put(int key, int value)
    {
        throw new NotImplementedException();
    }
}
