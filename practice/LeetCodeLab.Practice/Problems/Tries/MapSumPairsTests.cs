namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  677. Map Sum Pairs                                                 [Medium]
//  https://leetcode.com/problems/map-sum-pairs/
// ----------------------------------------------------------------------------
//  Build a map from string keys to integer values supporting two operations.
//  Insert stores a key and value, REPLACING any value already stored under
//  that key. Sum returns the total of the values of every key starting with
//  the given prefix.
//
//  Examples
//    MapSum, insert, sum, insert, sum
//      with [[],["apple",3],["ap"],["app",2],["ap"]]
//      ->   [null,null,3,null,5]
//    MapSum, insert, insert, sum
//      with [[],["a",3],["a",2],["a"]]
//      ->   [null,null,null,2]
//    MapSum, insert, sum, sum
//      with [[],["apple",3],["b"],["apple"]]
//      ->   [null,null,0,3]
//
//  Constraints
//    keys and prefixes are lowercase letters, 1 to 50 characters
//    1 <= value <= 1000
//    up to 50 calls in total
//    inserting an existing key overwrites rather than adds
//
//  Hints (read only as many as you need)
//    1. A plain dictionary makes Insert trivial and turns Sum into a scan of
//       every key. A trie makes Sum a walk down the prefix. Both are
//       acceptable at this size; the trie is the point of the exercise.
//    2. Store a running total on every trie node, so Sum is just a descent to
//       the prefix node and a single read.
//    3. Overwriting is the trap. If a key already exists you must apply the
//       DIFFERENCE between the new and old values along its path, not the new
//       value - otherwise a re-insert inflates every total above it. Keep a
//       separate dictionary of current values to compute that delta.
//
//  Aim for O(key length) per operation
// ============================================================================
[Problem(677, Target = typeof(MapSum))]
public sealed class MapSumPairsTests : ProblemTests<MapSumPairsTests>;

public class MapSum
{
    public MapSum()
    {
        throw new NotImplementedException();
    }

    public void Insert(string key, int val)
    {
        throw new NotImplementedException();
    }

    public int Sum(string prefix)
    {
        throw new NotImplementedException();
    }
}
