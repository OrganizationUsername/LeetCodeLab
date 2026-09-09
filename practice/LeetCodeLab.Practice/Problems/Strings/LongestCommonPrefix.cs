namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  14. Longest Common Prefix                                            [Easy]
//  https://leetcode.com/problems/longest-common-prefix/
// ----------------------------------------------------------------------------
//  Return the longest string that every input begins with. Return an empty
//  string when there is no shared prefix.
//
//  Examples
//    strs = ["flower","flow","flight"]  ->  "fl"
//    strs = ["dog","racecar","car"]  ->  ""
//    strs = ["interspecies","interstellar","interstate"]  ->  "inters"
//
//  Constraints
//    1 <= strs.Length <= 200
//    0 <= strs[i].Length <= 200
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. Take the first string as a working prefix.
//    2. Trim it against each subsequent string until that string starts with
//       it.
//    3. Alternatively compare column by column: walk position 0, 1, 2 across
//       all strings and stop at the first mismatch or the first string that
//       ends.
//
//  Aim for O(total characters) time
// ============================================================================
[Problem(14)]
public sealed class LongestCommonPrefix : ProblemTests<LongestCommonPrefix>
{
    public string Solve(string[] strs)
    {
        throw new NotImplementedException();
    }
}
