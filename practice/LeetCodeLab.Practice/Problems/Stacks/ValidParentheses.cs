namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  20. Valid Parentheses                                                [Easy]
//  https://leetcode.com/problems/valid-parentheses/
// ----------------------------------------------------------------------------
//  The string contains only the six bracket characters. Return true when
//  every bracket is closed by the matching type in the correct order.
//
//  Examples
//    s = "()"  ->  true
//    s = "()[]{}"  ->  true
//    s = "(]"  ->  false
//
//  Constraints
//    1 <= s.Length <= 10^4
//
//  Hints (read only as many as you need)
//    1. Counting brackets is not enough: the string ([)] has balanced counts
//       but is wrong.
//    2. Push every opening bracket. On a closing bracket, the most recent
//       unmatched opener must be its partner.
//    3. That is exactly a stack. Reject on a mismatch or on a closing bracket
//       with an empty stack, and require the stack to be empty at the end.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(20)]
public sealed class ValidParentheses : ProblemTests<ValidParentheses>
{
    public bool Solve(string s)
    {
        throw new NotImplementedException();
    }
}
