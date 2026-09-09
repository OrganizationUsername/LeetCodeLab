namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  692. Top K Frequent Words                                          [Medium]
//  https://leetcode.com/problems/top-k-frequent-words/
// ----------------------------------------------------------------------------
//  Return the k most frequent words, most frequent first. Words appearing the
//  same number of times are ordered lexicographically, smallest first.
//
//  Examples
//    words = ["i","love","leetcode","i","love","coding"], k = 2  ->  ["i","love"]
//    words = ["the","day","is","sunny","the","the","the"..., k = 4  ->  ["the","is","sunny","day"]
//    words = ["a"], k = 1  ->  ["a"]
//
//  Constraints
//    1 <= words.Length <= 500
//    words are lowercase letters
//    1 <= k <= number of distinct words
//    the tie-break is lexicographic ASCENDING, while the frequency ordering is DESCENDING
//
//  Hints (read only as many as you need)
//    1. Count first with a dictionary. The whole problem is then how you
//       order the distinct words.
//    2. The comparison has two keys pulling in opposite directions: higher
//       count wins, but on a tie the SMALLER word wins. Getting one of them
//       backwards is the bug this problem is really testing.
//    3. Sorting all distinct words is O(d log d) and perfectly acceptable.
//       For O(d log k), keep a heap of size k whose comparator is
//       deliberately INVERTED - the worst entry sits on top so it can be
//       evicted - then reverse what you drain out.
//
//  Aim for O(d log k) time with a bounded heap
// ============================================================================
[Problem(692)]
public sealed class TopKFrequentWords : ProblemTests<TopKFrequentWords>
{
    public IList<string> Solve(string[] words, int k)
    {
        throw new NotImplementedException();
    }
}
