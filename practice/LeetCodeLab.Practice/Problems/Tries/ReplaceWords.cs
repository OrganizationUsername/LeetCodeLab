namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  648. Replace Words                                                 [Medium]
//  https://leetcode.com/problems/replace-words/
// ----------------------------------------------------------------------------
//  A root followed by other letters forms a derivative: cat is a root of
//  cattle. Replace every word of the sentence that has a root in the
//  dictionary with that root, and when several roots apply use the shortest.
//  Words are separated by single spaces.
//
//  Examples
//    dictionary = ["cat","bat","rat"], sentence = "thecattlewasrattledbythebattery"  ->  "thecatwasratbythebat"
//    dictionary = ["a","b","c"], sentence = "aadsfasfabsbsbbabcadsfafs"  ->  "aabc"
//    dictionary = ["catt","cat","bat","rat"], sentence = "thecattlewasrattledbythebattery"  ->  "thecatwasratbythebat"
//
//  Constraints
//    1 <= dictionary.Length <= 1000
//    1 <= sentence length <= 10^6
//    lowercase letters and single spaces only
//
//  Hints (read only as many as you need)
//    1. Checking every root against every word is roots x words x length. The
//       roots share a great many prefixes, which is the waste to attack.
//    2. Store the roots in a prefix tree, one node per letter, marking the
//       nodes where a root ends.
//    3. Then walk each word down the trie one letter at a time and stop at
//       the first end-of-root marker you hit; that is the shortest root by
//       construction. Fall back to the original word if you run out of trie.
//
//  Aim for O(total input length) time
// ============================================================================
[Problem(648)]
public sealed class ReplaceWords : ProblemTests<ReplaceWords>
{
    public string Solve(string[] dictionary, string sentence)
    {
        throw new NotImplementedException();
    }
}
