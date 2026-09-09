namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  1268. Search Suggestions System                                    [Medium]
//  https://leetcode.com/problems/search-suggestions-system/
// ----------------------------------------------------------------------------
//  As each character of searchWord is typed, suggest up to three products
//  that start with what has been typed so far, choosing the lexicographically
//  smallest three. Return one list of suggestions per character typed, so the
//  answer has exactly searchWord.Length entries.
//
//  Examples
//    products = ["mobile","mouse","moneypot","monitor","mou..., searchWord = "mouse"  ->  [["mobile","moneypot","monitor"],["mobile",...
//    products = ["havana"], searchWord = "havana"  ->  [["havana"],["havana"],["havana"],["havana"...
//    products = ["bags","baggage","banner","box","cloths"], searchWord = "bags"  ->  [["baggage","bags","banner"],["baggage","ba...
//
//  Constraints
//    1 <= products.Length <= 1000
//    1 <= searchWord.Length <= 1000
//    products and searchWord are lowercase letters
//    at most three suggestions per keystroke, lexicographically smallest first
//    the outer list has one entry per character, even when there are no matches
//
//  Hints (read only as many as you need)
//    1. Sort the products once. After that, everything matching a prefix sits
//       in one contiguous block, and the smallest three are simply the first
//       three of that block.
//    2. Binary search for the start of the block on each keystroke, then take
//       up to three while they still carry the prefix.
//    3. The trie version stores, at each node, the three smallest words
//       passing through it - built once, then each keystroke is a single step
//       down. Either is accepted; the sorted-array version is far less code.
//
//  Aim for O(n log n + searchWord.Length * log n) time
// ============================================================================
[Problem(1268)]
public sealed class SearchSuggestionsSystem : ProblemTests<SearchSuggestionsSystem>
{
    public IList<IList<string>> Solve(string[] products, string searchWord)
    {
        throw new NotImplementedException();
    }
}
