namespace LeetCodeLab.Practice.Problems.Fabrication;

// ============================================================================
//  9016. Fastener Layout                                                [Easy]
// ----------------------------------------------------------------------------
//  Fasteners run along a member of the given length. The first and last sit
//  endDistance in from each end, and the rest are spread evenly between them.
//  Centre-to-centre spacing may not exceed maxSpacing. Return the fewest
//  fasteners that satisfies this. When the two end fasteners would meet or
//  cross - that is, when the length between them is zero or negative - a
//  single fastener is the answer.
//
//  Examples
//    runLength = 100, maxSpacing = 12, endDistance = 2  ->  9
//    runLength = 100, maxSpacing = 12.5, endDistance = 2  ->  9
//    runLength = 10, maxSpacing = 12, endDistance = 2  ->  2
//
//  Constraints
//    runLength > 0, maxSpacing > 0, endDistance >= 0
//    the answer is a count, so it is exact - but getting there involves division
//    compare with a relative slop of about 1e-9: in binary, 1.1 / 0.1 is 11.000000000000002, and rounding that up adds a fastener nobody needs
//
//  Hints (read only as many as you need)
//    1. Fasteners and gaps are different counts. Work out the number of GAPS
//       first, then convert.
//    2. The span to cover is runLength minus twice endDistance. If g gaps
//       must each be at most maxSpacing, the smallest g is that span divided
//       by maxSpacing, rounded up - and the fastener count is g + 1.
//    3. Rounding up is where this breaks. Math.Ceiling on a quotient that
//       should be a whole number can land one too high, so subtract a small
//       relative epsilon before the ceiling. Also force at least one gap, and
//       deal with the zero-or-negative span before you divide anything.
//
//  Aim for O(1) time and space
// ============================================================================
[Problem(9016)]
public sealed class FastenerLayout : ProblemTests<FastenerLayout>
{
    public int Solve(double runLength, double maxSpacing, double endDistance)
    {
        throw new NotImplementedException();
    }
}
