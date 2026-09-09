namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  122. Best Time to Buy and Sell Stock II                            [Medium]
//  https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
// ----------------------------------------------------------------------------
//  You may buy and sell as often as you like, but you can hold at most one
//  share at a time and must sell before buying again. Selling and buying
//  again on the same day is allowed. Return the greatest total profit.
//
//  Examples
//    prices = [7,1,5,3,6,4]  ->  7
//    prices = [1,2,3,4,5]  ->  4
//    prices = [7,6,4,3,1]  ->  0
//
//  Constraints
//    1 <= prices.Length <= 3*10^4
//    0 <= prices[i] <= 10^4
//    at most one share held at any moment
//    unlimited transactions, unlike Best Time to Buy and Sell Stock
//
//  Hints (read only as many as you need)
//    1. Because you may trade every day, you never have to choose between two
//       rises - you can take them all.
//    2. Any profitable multi-day run can be split into its consecutive
//       day-to-day steps without losing anything, since the intermediate buys
//       and sells cancel.
//    3. So just add up every positive difference between consecutive days.
//       Trying to find the actual peaks and valleys gives the same number
//       with far more code.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(122)]
public sealed class BestTimeToBuyAndSellStockII : ProblemTests<BestTimeToBuyAndSellStockII>
{
    public int Solve(int[] prices)
    {
        throw new NotImplementedException();
    }
}
