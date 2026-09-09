namespace LeetCodeLab.Practice.Problems.Numerics;

// ============================================================================
//  9012. Moment from a Shear Diagram                                    [Easy]
// ----------------------------------------------------------------------------
//  A solver reports shear v at stations x along a member, and moment is the
//  running integral of shear. Return the moment at every station, taking the
//  moment at the first station as zero and integrating between stations with
//  the trapezoidal rule. The stations are increasing but NOT evenly spaced,
//  which is what a mesh refined near the supports looks like.
//
//  Examples
//    x = [0,1,2], v = [10,10,10]  ->  [0,10,20]
//    x = [0,5,10], v = [50,0,-50]  ->  [0,125,0]
//    x = [0,2], v = [3,7]  ->  [0,10]
//
//  Constraints
//    2 <= x.Length == v.Length <= 10^5
//    x is strictly increasing
//    the first returned value is always 0
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. The area under the shear between two stations is a trapezoid: the
//       average of the two shear values times the distance between them.
//    2. Assuming a constant station spacing is the mistake to avoid. Take the
//       spacing from the x values every step.
//    3. Carry a running total rather than re-summing from the start at each
//       station, which turns an O(n^2) loop into a single pass - the same
//       prefix-sum idea, over a non-uniform grid.
//
//  Aim for O(n) time, O(n) space for the result
// ============================================================================
[Problem(9012)]
public sealed class MomentFromShearDiagram : ProblemTests<MomentFromShearDiagram>
{
    public double[] Solve(double[] x, double[] v)
    {
        throw new NotImplementedException();
    }
}
