namespace LeetCodeLab.Practice.Problems.Strings;

// ============================================================================
//  443. String Compression                                            [Medium]
//  https://leetcode.com/problems/string-compression/
// ----------------------------------------------------------------------------
//  Compress the array in place. Each run of the same character becomes that
//  character followed by the run length in decimal, except that a run of
//  length 1 is written as the character alone. Return the new length; only
//  the first that many entries are checked, and the rest may hold anything.
//
//  Examples
//    chars = ["a","a","b","b","c","c","c"]  ->  6, with the first 6 entries ["a","2","b","2","c","3"]
//    chars = ["a"]  ->  1, with the first 1 entries ["a"]
//    chars = ["a","b","b","b","b","b","b","b","b","b","b...  ->  4, with the first 4 entries ["a","b","1","2"]
//
//  Constraints
//    1 <= chars.Length <= 2000
//    entries are letters, digits or symbols
//    a run of length 1 gets NO number after it
//    a run of 10 or more contributes several digit characters, one per array slot
//
//  Hints (read only as many as you need)
//    1. Two indices moving at different speeds: one reading the runs, one
//       writing the compressed form behind it. The write index never
//       overtakes the read index, which is why this fits in place.
//    2. For each run, write the character, then - only if the length is above
//       1 - write the digits of that length.
//    3. The multi-digit case is where this breaks: a run of 12 needs the
//       characters '1' and '2' in two separate slots. Convert the count to a
//       string, or write the digits backwards and reverse that stretch.
//
//  Aim for O(n) time, O(1) extra space
// ============================================================================
[Problem(443)]
public sealed class StringCompression : ProblemTests<StringCompression>
{
    public int Solve(char[] chars)
    {
        throw new NotImplementedException();
    }
}
