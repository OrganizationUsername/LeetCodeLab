namespace LeetCodeLab.Practice.Problems.Numerics;

// ============================================================================
//  9009. Solve a Linear System                                        [Medium]
// ----------------------------------------------------------------------------
//  Solve A x = b for x by Gaussian elimination. A is square and non-singular.
//  Return x. This is the kernel every direct finite element solver is built
//  on, so write it the way one would be written rather than inverting the
//  matrix.
//
//  Examples
//    a = [[2,1],[1,3]], b = [4,7]  ->  [1,2]
//    a = [[0,1],[1,0]], b = [2,3]  ->  [3,2]
//    a = [[4,-2,1],[-2,4,-2],[1,-2,4]], b = [3,0,9]  ->  [1,2,3]
//
//  Constraints
//    1 <= n <= 100, A is n by n and b has length n
//    A is non-singular, but a zero may still turn up in a pivot position
//    you may modify the arrays you are given
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Two stages: eliminate below the diagonal to leave an upper-triangular
//       system, then back-substitute from the last unknown upwards.
//    2. The textbook version divides by a[k][k], which fails outright when
//       that entry is zero and loses precision when it is merely small
//       compared to what is below it.
//    3. Partial pivoting fixes both: before eliminating column k, find the
//       row at or below k with the largest absolute entry in that column and
//       swap it up. Swap the matching entry of b too, which is the step
//       people forget. Never invert A - inversion is slower and less accurate
//       than elimination.
//
//  Aim for O(n^3) time, O(1) extra space
// ============================================================================
[Problem(9009)]
public sealed class SolveALinearSystem : ProblemTests<SolveALinearSystem>
{
    public double[] Solve(double[][] a, double[] b)
    {
        throw new NotImplementedException();
    }
}
