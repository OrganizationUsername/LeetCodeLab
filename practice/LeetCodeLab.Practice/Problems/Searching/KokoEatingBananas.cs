namespace LeetCodeLab.Practice.Problems.Searching;

// ============================================================================
//  875. Koko Eating Bananas                                           [Medium]
//  https://leetcode.com/problems/koko-eating-bananas/
// ----------------------------------------------------------------------------
//  Koko eats bananas at k per hour. Each hour she picks one pile and eats up
//  to k from it; if the pile has fewer, she eats it and stops for that hour.
//  Return the smallest k that clears every pile within h hours.
//
//  Examples
//    piles = [3,6,7,11], h = 8  ->  4
//    piles = [30,11,23,4,20], h = 5  ->  30
//    piles = [30,11,23,4,20], h = 6  ->  23
//
//  Constraints
//    1 <= piles.Length <= 10^4
//    piles.Length <= h <= 10^9
//    1 <= piles[i] <= 10^9
//
//  Hints (read only as many as you need)
//    1. Do not search the array. Binary search the ANSWER: the value of k,
//       between 1 and the largest pile.
//    2. For a candidate k, hours needed is the sum over piles of ceiling(pile
//       / k). Use (pile + k - 1) / k.
//    3. Feasibility is monotonic: if k works so does every larger k. Shrink
//       toward the smallest k that still fits in h.
//
//  Aim for O(n log(max pile)) time
// ============================================================================
[Problem(875)]
public sealed class KokoEatingBananas : ProblemTests<KokoEatingBananas>
{
    public int Solve(int[] piles, int h)
    {
        throw new NotImplementedException();
    }
}
