namespace LeetCodeLab.Practice.Problems.Numerics;

// ============================================================================
//  9010. Bracketed Polynomial Root                                      [Easy]
// ----------------------------------------------------------------------------
//  coefficients gives a polynomial in ascending powers, so [-2, 0, 1] means
//  x^2 - 2. The interval [lo, hi] is guaranteed to bracket exactly one root:
//  the polynomial changes sign across it, or is exactly zero at an end.
//  Return that root.
//
//  Examples
//    coefficients = [-2,0,1], lo = 0, hi = 2  ->  1.4142135623730951
//    coefficients = [-3,1], lo = 0, hi = 10  ->  3
//    coefficients = [3,-1], lo = 0, hi = 10  ->  3
//
//  Constraints
//    1 <= coefficients.Length <= 20
//    lo < hi
//    exactly one root lies in [lo, hi]
//    the answer is checked to 1e-5, so iterate until the interval is far tighter than that
//
//  Hints (read only as many as you need)
//    1. You are not given a derivative, so Newton-Raphson is out unless you
//       differentiate the polynomial yourself. There is a method that needs
//       nothing but the ability to evaluate and compare.
//    2. A sign change across an interval means a root is inside it. Cut the
//       interval in half and ask which half still has the sign change - the
//       answer is one bisection step.
//    3. Test the sign with f(mid) * f(lo) <= 0 rather than by comparing
//       magnitudes, and evaluate the polynomial by Horner's rule rather than
//       calling Math.Pow. Around 100 halvings takes any starting interval
//       below double precision, so a fixed iteration count is safer than a
//       while loop on tolerance.
//
//  Aim for O(iterations * degree) time, O(1) space
// ============================================================================
[Problem(9010)]
public sealed class BracketedPolynomialRoot : ProblemTests<BracketedPolynomialRoot>
{
    public double Solve(double[] coefficients, double lo, double hi)
    {
        throw new NotImplementedException();
    }
}
