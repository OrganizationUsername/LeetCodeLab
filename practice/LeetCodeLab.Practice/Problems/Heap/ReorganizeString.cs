using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  767. Reorganize String                                             [Medium]
//  https://leetcode.com/problems/reorganize-string/
// ----------------------------------------------------------------------------
//  Rearrange the letters so that no two neighbours are the same. Return any
//  arrangement that works, or the empty string if none exists. Several
//  answers are usually valid and all are accepted.
//
//  Examples
//    s = "aab"  ->  "aba"  (other answers may also be accepted)
//    s = "aaab"  ->  ""  (other answers may also be accepted)
//    s = "a"  ->  "a"  (other answers may also be accepted)
//
//  Constraints
//    1 <= s.Length <= 500
//    s is lowercase letters
//    any valid arrangement is accepted
//    return "" when it is impossible
//
//  Hints (read only as many as you need)
//    1. Work out first when it is impossible: if one letter appears more than
//       half the time (rounded up) there is no way to keep its copies apart.
//    2. Otherwise place the most frequent remaining letter each step, but
//       never the one you just placed. A max-heap keyed on remaining count
//       gives you that.
//    3. Pop the top two, append both, decrement, and push back whichever
//       still has copies left. Taking two at a time is what guarantees you
//       never repeat - the alternative is to fill even indices first, then
//       odd, starting with the most frequent letter.
//
//  Aim for O(n log 26) time
// ============================================================================
[Problem(767)]
public sealed class ReorganizeString : ProblemTests<ReorganizeString>
{
    public string Solve(string s)
    {
        throw new NotImplementedException();
    }

    /// <summary>Harness plumbing: any arrangement with the same letters and no equal neighbours passes.</summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        string input = (string)args[0]!;
        string want = expected.GetString() ?? "";
        string got = actual as string ?? "";

        if (want.Length == 0) return got.Length == 0;
        if (got.Length != input.Length) return false;
        for (int i = 1; i < got.Length; i++)
            if (got[i] == got[i - 1]) return false;

        return string.Concat(got.OrderBy(c => c)) == string.Concat(input.OrderBy(c => c));
    }
}
