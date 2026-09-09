namespace LeetCodeLab.Practice.Problems.Backtracking;

// ============================================================================
//  22. Generate Parentheses                                           [Medium]
//  https://leetcode.com/problems/generate-parentheses/
// ----------------------------------------------------------------------------
//  Return every well-formed string of n pairs of parentheses. Any order is
//  accepted.
//
//  Examples
//    n = 3  ->  ["((()))","(()())","(())()","()(())","()()()"]
//    n = 1  ->  ["()"]
//    n = 2  ->  ["(())","()()"]
//
//  Constraints
//    1 <= n <= 8
//
//  Hints (read only as many as you need)
//    1. Build the string one character at a time rather than filtering all
//       possible strings.
//    2. Track how many opening and closing brackets you have placed so far.
//    3. You may place an opening bracket while fewer than n have been used,
//       and a closing bracket only while it would not outnumber the openings.
//       That rule alone guarantees well-formedness.
//
//  Aim for O(4^n / sqrt(n)) results
// ============================================================================
[Problem(22)]
public sealed class GenerateParentheses : ProblemTests<GenerateParentheses>
{
    public IList<string> Solve(int n)
    {
        throw new NotImplementedException();
    }
}
