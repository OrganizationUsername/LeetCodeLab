namespace LeetCodeLab.Practice.Problems.Numbers;

// ============================================================================
//  50. Pow(x, n)                                                      [Medium]
//  https://leetcode.com/problems/powx-n/
// ----------------------------------------------------------------------------
//  Compute x raised to the power n, where n may be negative. Multiplying in a
//  loop is too slow for large exponents.
//
//  Examples
//    x = 2.0, n = 10  ->  1024.0
//    x = 2.1, n = 3  ->  9.261
//    x = 2.0, n = -2  ->  0.25
//
//  Constraints
//    -100.0 < x < 100.0
//    -2^31 <= n <= 2^31 - 1
//
//  Hints (read only as many as you need)
//    1. A negative exponent means take the reciprocal. Careful: negating
//       int.MinValue overflows, so widen to long first.
//    2. Exponentiation by squaring halves the exponent each step: x^n is
//       (x^(n/2)) squared, times one extra x when n is odd.
//    3. That turns O(n) multiplications into O(log n). Answers are compared
//       with a 1e-5 tolerance.
//
//  Aim for O(log n) time
// ============================================================================
[Problem(50)]
public sealed class PowXN : ProblemTests<PowXN>
{
    public double Solve(double x, int n)
    {
        throw new NotImplementedException();
    }
}
