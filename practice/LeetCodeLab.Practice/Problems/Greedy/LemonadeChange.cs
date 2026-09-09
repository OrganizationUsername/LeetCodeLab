namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  860. Lemonade Change                                                 [Easy]
//  https://leetcode.com/problems/lemonade-change/
// ----------------------------------------------------------------------------
//  Each lemonade costs 5. Customers queue up paying with a 5, 10 or 20 note,
//  and you must give the correct change immediately from notes you have
//  already taken. You start with nothing. Return whether every customer can
//  be served.
//
//  Examples
//    bills = [5,5,5,10,20]  ->  true
//    bills = [5,5,10,10,20]  ->  false
//    bills = [5,5,10]  ->  true
//
//  Constraints
//    1 <= bills.Length <= 10^5
//    each bill is 5, 10 or 20
//    change must be given at the moment of sale, from notes already received
//
//  Hints (read only as many as you need)
//    1. Only the counts of fives and tens matter; a twenty is never useful as
//       change, so there is no need to count them.
//    2. A ten needs one five. A twenty needs either a ten and a five, or
//       three fives.
//    3. For a twenty, always prefer the ten-and-five combination. Fives are
//       the flexible note - they can pay for a ten as well - so spending
//       three of them when a ten was available is what makes an otherwise
//       servable queue fail.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(860)]
public sealed class LemonadeChange : ProblemTests<LemonadeChange>
{
    public bool Solve(int[] bills)
    {
        throw new NotImplementedException();
    }
}
