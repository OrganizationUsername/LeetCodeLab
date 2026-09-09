namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  1642. Furthest Building You Can Reach                              [Medium]
//  https://leetcode.com/problems/furthest-building-you-can-reach/
// ----------------------------------------------------------------------------
//  You start on building 0 and move to the next building each step. Going
//  down or staying level is free. Going UP by d costs either d bricks or one
//  ladder, and a ladder covers any height. Return the index of the furthest
//  building you can reach.
//
//  Examples
//    heights = [4,2,7,6,9,14,12], bricks = 5, ladders = 1  ->  4
//    heights = [4,12,2,7,3,18,20,3,19], bricks = 10, ladders = 2  ->  7
//    heights = [14,3,19,3], bricks = 17, ladders = 0  ->  3
//
//  Constraints
//    1 <= heights.Length <= 10^5
//    0 <= bricks <= 10^9, 0 <= ladders <= heights.Length
//    descents and level moves are always free
//    return an INDEX, not a count of buildings
//
//  Hints (read only as many as you need)
//    1. Ladders are the scarce resource and they are worth most on the
//       biggest climbs - but you do not know which climbs are biggest until
//       you have seen them.
//    2. So commit ladders greedily to every climb as you meet it, and take
//       one back later when a bigger climb turns up.
//    3. Keep the ladder-assigned climbs in a MIN-heap. When a new climb
//       arrives and no ladders remain, pop the smallest ladder climb; if the
//       new climb is bigger, give it the ladder and pay bricks for the small
//       one instead. Run out of bricks and the previous index is the answer.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(1642)]
public sealed class FurthestBuilding : ProblemTests<FurthestBuilding>
{
    public int Solve(int[] heights, int bricks, int ladders)
    {
        throw new NotImplementedException();
    }
}
