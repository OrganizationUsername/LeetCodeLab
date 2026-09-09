namespace LeetCodeLab.Practice.Problems.Parsing;

// ============================================================================
//  9018. Evaluate a Load Combination                                  [Medium]
// ----------------------------------------------------------------------------
//  Evaluate a load combination written the way a code table writes it, such
//  as 1.2D + 1.6L + 0.5S. Each term is an optional sign, an optional decimal
//  coefficient, and a load case name; a missing coefficient means 1. Terms
//  are joined by + or -, and spaces may appear anywhere or nowhere. names and
//  values line up, giving the numeric value of each case. Return the total.
//
//  Examples
//    expression = "1.2D+1.6L", names = ["D","L"], values = [10,20]  ->  44
//    expression = "D+L", names = ["D","L"], values = [10,20]  ->  30
//    expression = "0.9D-1.0W", names = ["D","W"], values = [100,40]  ->  50
//
//  Constraints
//    1 <= names.Length == values.Length <= 20
//    names are letters only, and CAN be more than one letter - Lr and L may both be in the list
//    every name used in the expression appears in names
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Split into terms before you evaluate anything: scan for + and - that
//       separate terms, keeping the sign with the term that follows it.
//    2. Within a term, the leading run of digits, dots and the sign is the
//       coefficient and the rest is the name. An empty coefficient means 1,
//       and a lone minus means -1.
//    3. Watch the name matching. If the list holds both L and Lr, matching
//       the first name that fits turns 1.6Lr into 1.6 times L with a stray r
//       left over. Match the LONGEST name that the term ends with, and the
//       ambiguity disappears.
//
//  Aim for O(expression length * names) time
// ============================================================================
[Problem(9018)]
public sealed class EvaluateLoadCombination : ProblemTests<EvaluateLoadCombination>
{
    public double Solve(string expression, string[] names, double[] values)
    {
        throw new NotImplementedException();
    }
}
