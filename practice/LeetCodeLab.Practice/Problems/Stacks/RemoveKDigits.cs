namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  402. Remove K Digits                                               [Medium]
//  https://leetcode.com/problems/remove-k-digits/
// ----------------------------------------------------------------------------
//  Remove exactly k digits from the number so that what remains, read in the
//  same order, is the smallest possible. Return it as a string with no
//  leading zeros, or "0" if everything is removed.
//
//  Examples
//    num = "1432219", k = 3  ->  "1219"
//    num = "10200", k = 1  ->  "200"
//    num = "10", k = 2  ->  "0"
//
//  Constraints
//    1 <= num.Length <= 10^5
//    0 <= k <= num.Length
//    num has no leading zeros of its own, except the single digit "0"
//    the result must not have leading zeros; the empty result is "0"
//
//  Hints (read only as many as you need)
//    1. A digit is worth removing when a smaller digit follows it, because
//       the earlier position carries more weight.
//    2. Sweep left to right keeping a stack that never decreases: while the
//       top is greater than the incoming digit and removals remain, pop it.
//    3. Three loose ends decide whether this passes: unused removals at the
//       end must come off the BACK, leading zeros need stripping afterwards,
//       and an empty result becomes "0". Each of those has its own test here.
//
//  Aim for O(n) time
// ============================================================================
[Problem(402)]
public sealed class RemoveKDigits : ProblemTests<RemoveKDigits>
{
    public string Solve(string num, int k)
    {
        throw new NotImplementedException();
    }
}
