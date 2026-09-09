namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  678. Valid Parenthesis String                                      [Medium]
//  https://leetcode.com/problems/valid-parenthesis-string/
// ----------------------------------------------------------------------------
//  The string holds only the characters (, ) and *. Each * may stand for a
//  single open bracket, a single close bracket, or nothing at all. Return
//  whether some choice makes the whole string a balanced parenthesis
//  sequence.
//
//  Examples
//    s = "()"  ->  true
//    s = "(*)"  ->  true
//    s = "(*))"  ->  true
//
//  Constraints
//    1 <= s.Length <= 100
//    the string contains only the characters '(', ')' and '*'
//    each star is decided independently
//
//  Hints (read only as many as you need)
//    1. Trying all three options per star is exponential. Instead of
//       committing, track the RANGE of open-bracket counts still possible.
//    2. Carry two numbers: the fewest open brackets you could have, and the
//       most. An open bracket raises both, a close lowers both, and a star
//       lowers the low and raises the high.
//    3. Clamp the low at zero, since you can never owe brackets, and fail
//       immediately if the high ever drops below zero. The string is valid
//       exactly when the low is back to zero at the end.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(678)]
public sealed class ValidParenthesisString : ProblemTests<ValidParenthesisString>
{
    public bool Solve(string s)
    {
        throw new NotImplementedException();
    }
}
