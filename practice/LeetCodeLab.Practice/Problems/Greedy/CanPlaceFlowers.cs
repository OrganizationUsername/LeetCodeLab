namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  605. Can Place Flowers                                               [Easy]
//  https://leetcode.com/problems/can-place-flowers/
// ----------------------------------------------------------------------------
//  The flowerbed is a row of plots, 1 planted and 0 empty. No two flowers may
//  occupy adjacent plots. Return whether n more flowers can be planted
//  without breaking that rule.
//
//  Examples
//    flowerbed = [1,0,0,0,1], n = 1  ->  true
//    flowerbed = [1,0,0,0,1], n = 2  ->  false
//    flowerbed = [0], n = 1  ->  true
//
//  Constraints
//    1 <= flowerbed.Length <= 2*10^4
//    the existing arrangement already obeys the no-adjacent rule
//    0 <= n <= flowerbed.Length
//    the plots before the first and after the last count as empty
//
//  Hints (read only as many as you need)
//    1. Sweep left to right and plant the moment a plot is legal. Planting as
//       early as possible never blocks a placement you could otherwise have
//       made.
//    2. A plot is legal when it is empty and both neighbours are empty -
//       treating off-the-end as empty, which is what makes the first and last
//       plots plantable.
//    3. Remember to actually WRITE the flower into the array as you plant, or
//       the next plot will not see it and you will double-plant adjacent
//       cells. Stop early once you have placed n.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(605)]
public sealed class CanPlaceFlowers : ProblemTests<CanPlaceFlowers>
{
    public bool Solve(int[] flowerbed, int n)
    {
        throw new NotImplementedException();
    }
}
