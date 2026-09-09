namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  150. Evaluate Reverse Polish Notation                              [Medium]
//  https://leetcode.com/problems/evaluate-reverse-polish-notation/
// ----------------------------------------------------------------------------
//  Evaluate an expression in reverse Polish notation, where each operator
//  follows its two operands. Division truncates toward zero.
//
//  Examples
//    tokens = ["2","1","+","3","*"]  ->  9
//    tokens = ["4","13","5","/","+"]  ->  6
//    tokens = ["10","6","9","3","+","-11","*","/","*","17...  ->  22
//
//  Constraints
//    1 <= tokens.Length <= 10^4
//    operators are + - * /
//    the expression is always valid
//
//  Hints (read only as many as you need)
//    1. Push numbers. On an operator, pop two values, apply, push the result.
//    2. Order matters for subtraction and division: the value popped FIRST is
//       the right-hand operand.
//    3. C# integer division already truncates toward zero, so a / b needs no
//       adjustment.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(150)]
public sealed class EvaluateReversePolishNotation : ProblemTests<EvaluateReversePolishNotation>
{
    public int Solve(string[] tokens)
    {
        throw new NotImplementedException();
    }
}
