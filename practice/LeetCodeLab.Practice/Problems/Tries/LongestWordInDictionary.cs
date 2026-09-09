namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  720. Longest Word in Dictionary                                    [Medium]
//  https://leetcode.com/problems/longest-word-in-dictionary/
// ----------------------------------------------------------------------------
//  Return the longest word that can be built one letter at a time, where
//  every prefix along the way is also a word in the list. Break ties by
//  taking the lexicographically smallest. Return the empty string if nothing
//  qualifies.
//
//  Examples
//    words = ["w","wo","wor","worl","world"]  ->  "world"
//    words = ["a","banana","app","appl","ap","apply","ap...  ->  "apple"
//    words = ["ab","abc"]  ->  ""
//
//  Constraints
//    1 <= words.Length <= 1000
//    1 <= words[i].Length <= 30
//    lowercase English letters only
//
//  Hints (read only as many as you need)
//    1. Buildable is recursive: w qualifies when w without its last letter
//       also qualifies, and a single letter qualifies on its own.
//    2. So a word can only be judged after all its prefixes have been.
//       Sorting by length, or walking a trie in breadth-first order, gives
//       you that ordering for free.
//    3. Sort the words, then keep a HashSet of the ones you have accepted.
//       Accept w when w.Length == 1 or the set already contains w minus its
//       last character. Sorted order also makes the first longest word you
//       find the lexicographically smallest.
//
//  Aim for O(n log n + total length) time
// ============================================================================
[Problem(720)]
public sealed class LongestWordInDictionary : ProblemTests<LongestWordInDictionary>
{
    public string Solve(string[] words)
    {
        throw new NotImplementedException();
    }
}
