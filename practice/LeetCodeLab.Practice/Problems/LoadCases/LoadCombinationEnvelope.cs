namespace LeetCodeLab.Practice.Problems.LoadCases;

// ============================================================================
//  9007. Load Combination Envelope                                    [Medium]
// ----------------------------------------------------------------------------
//  caseResults has one row per load case and one column per station along a
//  member, holding that case's result at that station. factors has one row
//  per load combination and one entry per load case. A combination's result
//  at a station is the sum over load cases of factor times that case's value
//  there. Return [maxEnvelope, minEnvelope]: two rows, each with one entry
//  per station, giving the largest and smallest value any combination
//  produces there.
//
//  Examples
//    caseResults = [[10,20],[5,5]], factors = [[1,1],[1.2,1.6]]  ->  [[20,32],[15,25]]
//    caseResults = [[100],[60]], factors = [[1.4,0],[0.9,-1.0]]  ->  [[140],[30]]
//    caseResults = [[1,2,3]], factors = [[2]]  ->  [[2,4,6],[2,4,6]]
//
//  Constraints
//    1 <= load cases <= 50
//    1 <= stations <= 1000
//    1 <= combinations <= 200
//    every row of factors has exactly one entry per load case
//    factors may be negative, and the envelope is taken per station independently
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. The envelope is taken station by station. The combination that
//       governs at one station need not govern at any other, so you cannot
//       pick a single worst combination up front.
//    2. Three nested loops do it: for each combination, for each station, sum
//       over the load cases. Track a running max and min per station rather
//       than storing every combination.
//    3. Seed the running max and min from the FIRST combination, not from
//       zero. A set of combinations that are all negative would otherwise
//       report a maximum of zero, which is the kind of bug that quietly
//       under-designs something.
//
//  Aim for O(combinations * stations * cases) time, O(stations) extra space
// ============================================================================
[Problem(9007)]
public sealed class LoadCombinationEnvelope : ProblemTests<LoadCombinationEnvelope>
{
    public double[][] Solve(double[][] caseResults, double[][] factors)
    {
        throw new NotImplementedException();
    }
}
