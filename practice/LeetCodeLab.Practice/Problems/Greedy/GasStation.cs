namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  134. Gas Station                                                   [Medium]
//  https://leetcode.com/problems/gas-station/
// ----------------------------------------------------------------------------
//  Stations are arranged in a circle. At station i you gain gas[i] and spend
//  cost[i] driving to the next. Return the starting index that lets you
//  complete the loop, or -1 if none does. The answer is unique when it
//  exists.
//
//  Examples
//    gas = [1,2,3,4,5], cost = [3,4,5,1,2]  ->  3
//    gas = [2,3,4], cost = [3,4,3]  ->  -1
//    gas = [5,1,2,3,4], cost = [4,4,1,5,1]  ->  4
//
//  Constraints
//    1 <= gas.Length <= 10^5
//    0 <= gas[i], cost[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. If the total gas is less than the total cost, no start works. That
//       check alone settles the -1 case.
//    2. Otherwise a valid start exists and is unique, so you only need to
//       find it.
//    3. Sweep once with a running tank. Whenever the tank goes negative, no
//       station from the current candidate up to here can be the start, so
//       make the next station the candidate and reset the tank.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(134)]
public sealed class GasStation : ProblemTests<GasStation>
{
    public int Solve(int[] gas, int[] cost)
    {
        throw new NotImplementedException();
    }
}
