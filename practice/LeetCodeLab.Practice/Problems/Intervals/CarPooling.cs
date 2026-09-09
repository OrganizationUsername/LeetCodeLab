namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  1094. Car Pooling                                                  [Medium]
//  https://leetcode.com/problems/car-pooling/
// ----------------------------------------------------------------------------
//  The car drives east only, never turning back. Each trip [passengers, from,
//  to] picks that many people up at from and sets them down at to. Return
//  whether every trip can be served without ever exceeding the capacity.
//
//  Examples
//    trips = [[2,1,5],[3,3,7]], capacity = 4  ->  false
//    trips = [[2,1,5],[3,3,7]], capacity = 5  ->  true
//    trips = [[2,1,5],[3,5,7]], capacity = 3  ->  true
//
//  Constraints
//    1 <= trips.Length <= 1000
//    1 <= passengers <= 100
//    0 <= from < to <= 1000
//    passengers get off AT the drop point, so a trip ending at x frees seats for a trip starting at x
//
//  Hints (read only as many as you need)
//    1. Only the points where the load changes matter, and there are at most
//       1001 of them.
//    2. A difference array over the locations: add passengers at from,
//       subtract at to. Then one running total across it gives the load
//       everywhere.
//    3. The drop-off convention is the whole trap. Subtracting at to rather
//       than at to+1 is what makes a trip ending at x free its seats for one
//       starting at x - get that backwards and back-to-back trips fail
//       incorrectly.
//
//  Aim for O(n + maxLocation) time
// ============================================================================
[Problem(1094)]
public sealed class CarPooling : ProblemTests<CarPooling>
{
    public bool Solve(int[][] trips, int capacity)
    {
        throw new NotImplementedException();
    }
}
