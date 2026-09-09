namespace LeetCodeLab.Practice.Problems.LoadCases;

// ============================================================================
//  9008. Axle Train Maximum Reaction                                    [Hard]
// ----------------------------------------------------------------------------
//  A simply supported span runs from x = 0 to x = span. A vehicle rolls
//  across it as a rigid train of point loads: axle i carries loads[i] and
//  sits offsets[i] behind the lead axle, with offsets[0] = 0. The train may
//  sit anywhere, including partly off either end, and only axles with 0 <= x
//  <= span put any load on the span. A single axle at position x contributes
//  load * (span - x) / span to the reaction at the left support. Return the
//  largest left-hand reaction over every position the train can take.
//
//  Examples
//    span = 10, loads = [10], offsets = [0]  ->  10
//    span = 10, loads = [10,10], offsets = [0,4]  ->  16
//    span = 10, loads = [10,20], offsets = [0,4]  ->  22
//
//  Constraints
//    1 <= loads.Length == offsets.Length <= 100
//    span > 0, loads[i] > 0
//    offsets are strictly increasing and offsets[0] == 0
//    the train may be longer than the span
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. The train's position is a continuous variable, so you cannot try them
//       all. Sweeping in small steps gets close but will miss the exact peak,
//       and the tolerance here is tight.
//    2. Hold the set of axles currently on the span fixed. Over that range of
//       positions, how does the reaction behave as the train advances? Work
//       out whether it rises, falls, or can turn around.
//    3. It falls linearly, because every axle on the span is moving away from
//       the left support. So the peak of each stretch is at its left-hand end
//       - the instants when the set of on-span axles changes. Those are
//       exactly the positions where some axle sits at x = 0 or at x = span,
//       which is a finite list of candidates you can evaluate directly.
//
//  Aim for O(n^2) time, O(1) space
// ============================================================================
[Problem(9008)]
public sealed class AxleTrainMaximumReaction : ProblemTests<AxleTrainMaximumReaction>
{
    public double Solve(double span, double[] loads, double[] offsets)
    {
        throw new NotImplementedException();
    }
}
