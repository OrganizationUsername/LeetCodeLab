namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  17. Letter Combinations of a Phone Number                          [Medium]
//  https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// ----------------------------------------------------------------------------
//  Given digits from 2 to 9, return every letter combination the number could
//  spell, using the classic phone keypad. An empty input returns an empty
//  list. Any order is accepted.
//
//  Examples
//    digits = "23"  ->  ["ad","ae","af","bd","be","bf","cd","ce","cf"]
//    digits = ""  ->  []
//    digits = "2"  ->  ["a","b","c"]
//
//  Constraints
//    0 <= digits.Length <= 4
//    digits are 2 through 9
//
//  Hints (read only as many as you need)
//    1. Map each digit to its letters. Note that 7 and 9 have four letters,
//       not three.
//    2. Then it is a straightforward product: for each letter of the current
//       digit, recurse on the rest.
//    3. Handle the empty input as a special case: it returns an empty list,
//       not a list containing an empty string.
//
//  Aim for O(4^n) results
// ============================================================================
[Problem(17)]
public sealed class LetterCombinations : ProblemTests<LetterCombinations>
{
    public IList<string> Solve(string digits)
    {
        throw new NotImplementedException();
    }
}
