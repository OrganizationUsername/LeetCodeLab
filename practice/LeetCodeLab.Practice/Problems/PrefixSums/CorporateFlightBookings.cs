namespace LeetCodeLab.Practice.Problems.PrefixSums;

// ============================================================================
//  1109. Corporate Flight Bookings                                    [Medium]
//  https://leetcode.com/problems/corporate-flight-bookings/
// ----------------------------------------------------------------------------
//  There are n flights numbered 1..n. Each booking [first, last, seats]
//  reserves that many seats on every flight from first to last inclusive.
//  Return an array of length n giving the total seats reserved on each
//  flight.
//
//  Examples
//    bookings = [[1,2,10],[2,3,20],[2,5,25]], n = 5  ->  [10,55,45,25,25]
//    bookings = [[1,2,10],[2,2,15]], n = 2  ->  [10,25]
//    bookings = [[1,1,5]], n = 1  ->  [5]
//
//  Constraints
//    1 <= n <= 2*10^4
//    1 <= bookings.Length <= 2*10^4
//    1 <= first <= last <= n
//    1 <= seats <= 10^4
//
//  Hints (read only as many as you need)
//    1. Writing seats into every flight of every range costs O(n) per
//       booking, and because the ranges overlap most of that writing gets
//       redone.
//    2. Instead of recording the value at each flight, record only where the
//       value CHANGES: plus seats where a range starts, minus seats just past
//       where it ends.
//    3. That is a difference array: two writes per booking, then a single
//       running total across it turns the deltas back into the answer.
//
//  Aim for O(n + m) time, O(n) space
// ============================================================================
[Problem(1109)]
public sealed class CorporateFlightBookings : ProblemTests<CorporateFlightBookings>
{
    public int[] Solve(int[][] bookings, int n)
    {
        throw new NotImplementedException();
    }
}
