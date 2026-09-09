namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  211. Design Add and Search Words Data Structure                    [Medium]
//  https://leetcode.com/problems/design-add-and-search-words-data-structure/
// ----------------------------------------------------------------------------
//  Store words and search them, where a search string may contain dots. A dot
//  matches any single letter. AddWord adds a word; Search returns whether any
//  stored word matches the pattern.
//
//  Examples
//    WordDictionary, AddWord, AddWord, AddWord, Search, Search, Search, Search
//      with [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
//      ->   [null,null,null,null,false,true,true,true]
//
//  Constraints
//    1 <= word.Length <= 25
//    added words are lowercase letters
//    search patterns may contain dots
//
//  Hints (read only as many as you need)
//    1. Start from a plain trie, exactly as in Implement Trie.
//    2. Search can no longer be a simple loop, because a dot forks the walk.
//    3. Make search recursive over (node, index). On a normal letter follow
//       that one child; on a dot recurse into EVERY child. A miss just
//       returns false and lets another branch try.
//
//  Aim for O(length) per add, O(26^dots * length) per search
// ============================================================================
[Problem(211, Target = typeof(WordDictionary))]
public sealed class WordDictionaryTests : ProblemTests<WordDictionaryTests>;

public class WordDictionary
{
    public WordDictionary()
    {
        throw new NotImplementedException();
    }

    public void AddWord(string word)
    {
        throw new NotImplementedException();
    }

    public bool Search(string word)
    {
        throw new NotImplementedException();
    }
}
