namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  231. Power of Two                                                    [Easy]
//  https://leetcode.com/problems/power-of-two/
// ----------------------------------------------------------------------------
//  Return whether n is a power of two, that is whether n equals 2 raised to
//  some non-negative integer power. Zero and negative numbers are not.
//
//  Examples
//    n = 1  ->  true
//    n = 16  ->  true
//    n = 3  ->  false
//
//  Constraints
//    -2^31 <= n <= 2^31 - 1
//    1 counts, because it is 2^0
//
//  Hints (read only as many as you need)
//    1. Dividing by two while the number stays even works. Then ask what a
//       power of two looks like written in binary.
//    2. Exactly one bit set. So the question becomes: does n have exactly one
//       bit set?
//    3. n & (n - 1) clears the lowest set bit. If the result is zero there
//       was only one bit, so the test is n > 0 && (n & (n - 1)) == 0. The n >
//       0 guard is not optional: without it, int.MinValue and 0 both slip
//       through.
//
//  Aim for O(1) time and space
// ============================================================================
[Problem(231)]
public sealed class PowerOfTwo : ProblemTests<PowerOfTwo>
{
    public bool Solve(int n)
    {
        throw new NotImplementedException();
    }
}
