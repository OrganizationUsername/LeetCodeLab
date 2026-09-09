namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  208. Implement Trie (Prefix Tree)                                  [Medium]
//  https://leetcode.com/problems/implement-trie-prefix-tree/
// ----------------------------------------------------------------------------
//  Implement a prefix tree over lowercase words. Insert adds a word. Search
//  returns true only for a complete inserted word. StartsWith returns true
//  when any inserted word begins with the given prefix.
//
//  Examples
//    Trie, insert, search, search, startsWith, insert, search
//      with [[],["apple"],["apple"],["app"],["app"],["app"],["app"]]
//      ->   [null,null,true,false,true,null,true]
//
//  Constraints
//    1 <= word.Length <= 2000
//    lowercase English letters
//    up to 3*10^4 calls
//
//  Hints (read only as many as you need)
//    1. Each node owns a map from next character to child node, plus a flag
//       for is a word ending here.
//    2. Insert walks the characters, creating missing children, and sets the
//       flag on the final node.
//    3. Search and StartsWith are the same walk; they differ only in whether
//       reaching the end requires that flag. Write the walk once and share
//       it.
//
//  Aim for O(length) per operation
// ============================================================================
[Problem(208, Target = typeof(Trie))]
public sealed class TrieTests : ProblemTests<TrieTests>;

public class Trie
{
    public Trie()
    {
        throw new NotImplementedException();
    }

    public void Insert(string word)
    {
        throw new NotImplementedException();
    }

    public bool Search(string word)
    {
        throw new NotImplementedException();
    }

    public bool StartsWith(string prefix)
    {
        throw new NotImplementedException();
    }
}
