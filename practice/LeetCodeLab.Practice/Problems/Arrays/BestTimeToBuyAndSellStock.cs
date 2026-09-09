namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  121. Best Time to Buy and Sell Stock                                 [Easy]
//  https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// ----------------------------------------------------------------------------
//  prices[i] is the price on day i. Buy on one day and sell on a strictly
//  later day, and return the maximum profit. If no trade is profitable,
//  return 0.
//
//  Examples
//    prices = [7,1,5,3,6,4]  ->  5
//    prices = [7,6,4,3,1]  ->  0
//
//  Constraints
//    1 <= prices.Length <= 10^5
//    0 <= prices[i] <= 10^4
//
//  Hints (read only as many as you need)
//    1. For any selling day, the best you could have done is to have bought
//       at the cheapest price before it.
//    2. So one pass suffices: track the minimum price seen so far, and the
//       best profit seen so far.
//    3. Be consistent about update order so you never sell before you buy.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(121)]
public sealed class BestTimeToBuyAndSellStock : ProblemTests<BestTimeToBuyAndSellStock>
{
    public int Solve(int[] prices)
    {
        throw new NotImplementedException();
    }
}
