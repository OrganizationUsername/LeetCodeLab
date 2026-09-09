namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  139. Word Break                                                    [Medium]
//  https://leetcode.com/problems/word-break/
// ----------------------------------------------------------------------------
//  Return true when s can be cut into a sequence of dictionary words. Words
//  may be reused, and not every dictionary word has to be used.
//
//  Examples
//    s = "leetcode", wordDict = ["leet","code"]  ->  true
//    s = "applepenapple", wordDict = ["apple","pen"]  ->  true
//    s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]  ->  false
//
//  Constraints
//    1 <= s.Length <= 300
//    dictionary words are distinct
//
//  Hints (read only as many as you need)
//    1. Plain recursion re-solves the same suffixes over and over and blows
//       up exponentially. The stress case is built to punish exactly that.
//    2. Define reachable[i] as: the first i characters can be segmented.
//       reachable[0] is true.
//    3. reachable[end] is true when some earlier reachable[start] is true and
//       the slice from start to end is in the dictionary. Put the dictionary
//       in a HashSet.
//
//  Aim for O(n^2) time with O(1) dictionary lookups
// ============================================================================
[Problem(139)]
public sealed class WordBreak : ProblemTests<WordBreak>
{
    public bool Solve(string s, IList<string> wordDict)
    {
        throw new NotImplementedException();
    }
}
