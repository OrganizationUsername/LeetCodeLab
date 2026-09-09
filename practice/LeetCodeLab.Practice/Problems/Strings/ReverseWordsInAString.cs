namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  151. Reverse Words in a String                                     [Medium]
//  https://leetcode.com/problems/reverse-words-in-a-string/
// ----------------------------------------------------------------------------
//  Reverse the order of the words. A word is a run of non-space characters.
//  The result must have exactly one space between words and none at either
//  end, however the input was spaced.
//
//  Examples
//    s = "theskyisblue"  ->  "blueisskythe"
//    s = "helloworld"  ->  "worldhello"
//    s = "agoodexample"  ->  "examplegooda"
//
//  Constraints
//    1 <= s.Length <= 10^4
//    the string may have leading, trailing and repeated spaces
//    there is at least one word
//    the words themselves are not reversed, only their order
//
//  Hints (read only as many as you need)
//    1. Splitting on spaces and discarding the empty pieces handles all the
//       spacing rules at once, then you reverse and rejoin.
//    2. In C# that is s.Split(' ', StringSplitOptions.RemoveEmptyEntries),
//       then Array.Reverse, then string.Join(" ", ...).
//    3. The interview version usually bans the library call. Then it becomes:
//       reverse the whole string in place, reverse each word back, and
//       compact the spaces in a single pass - all with two pointers and no
//       extra allocation.
//
//  Aim for O(n) time
// ============================================================================
[Problem(151)]
public sealed class ReverseWordsInAString : ProblemTests<ReverseWordsInAString>
{
    public string Solve(string s)
    {
        throw new NotImplementedException();
    }
}
