namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  49. Group Anagrams                                                 [Medium]
//  https://leetcode.com/problems/group-anagrams/
// ----------------------------------------------------------------------------
//  Group the strings so that words made of the same letters land in the same
//  group. Return the groups in any order, and the words within a group in any
//  order.
//
//  Examples
//    strs = ["eat","tea","tan","ate","nat","bat"]  ->  [["bat"],["nat","tan"],["ate","eat","tea"]]
//    strs = [""]  ->  [[""]]
//    strs = ["a"]  ->  [["a"]]
//
//  Constraints
//    1 <= strs.Length <= 10^4
//    0 <= strs[i].Length <= 100
//    lowercase English letters only
//
//  Hints (read only as many as you need)
//    1. Two words are anagrams exactly when some canonical form of them is
//       equal.
//    2. Sorting a word characters gives such a canonical form. So does a
//       26-slot letter count.
//    3. Use that canonical form as a Dictionary key mapping to the list of
//       words that produced it.
//
//  Aim for O(n * k log k) time, where k is word length
// ============================================================================
[Problem(49)]
public sealed class GroupAnagrams : ProblemTests<GroupAnagrams>
{
    public IList<IList<string>> Solve(string[] strs)
    {
        throw new NotImplementedException();
    }
}
