namespace LeetCodeLab.Practice.Problems.Numerics;

// ============================================================================
//  9011. Design Table Lookup                                          [Medium]
// ----------------------------------------------------------------------------
//  A code table is indexed by rowKeys down the side and colKeys across the
//  top, both strictly increasing, with table[i][j] the value at rowKeys[i]
//  and colKeys[j]. Return the value at (row, col), interpolating linearly in
//  both directions between the four surrounding entries. Do not extrapolate:
//  an argument outside the table clamps to the nearest edge, which is what
//  the code commentary means by using the boundary value.
//
//  Examples
//    rowKeys = [0,10], colKeys = [0,10], table = [[0,10],[10,20]], row = 5, col = 5  ->  10
//    rowKeys = [0,10], colKeys = [0,10], table = [[0,10],[10,20]], row = 0, col = 0  ->  0
//    rowKeys = [0,10], colKeys = [0,10], table = [[0,10],[10,20]], row = -5, col = 5  ->  5
//
//  Constraints
//    1 <= rowKeys.Length, colKeys.Length <= 1000
//    rowKeys and colKeys are strictly increasing
//    table is rowKeys.Length by colKeys.Length
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Do the two directions separately. Interpolating along a row is one
//       problem; combining two row results down the columns is the same
//       problem again.
//    2. For each axis you need the bracketing pair of keys and how far
//       between them you sit - a fraction from 0 to 1. Clamp that fraction to
//       [0, 1] and the no-extrapolation rule handles itself.
//    3. Watch the degenerate cases: a table with a single row or column has
//       no pair to bracket with, and an argument landing exactly on the last
//       key must not run off the end of the array. Both are fixed by clamping
//       the bracket INDEX to length - 2 before computing the fraction.
//
//  Aim for O(log n) time with binary search, O(1) space
// ============================================================================
[Problem(9011)]
public sealed class DesignTableLookup : ProblemTests<DesignTableLookup>
{
    public double Solve(double[] rowKeys, double[] colKeys, double[][] table, double row, double col)
    {
        throw new NotImplementedException();
    }
}
