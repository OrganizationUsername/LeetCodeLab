namespace LeetCodeLab.Practice.Problems.DynamicProgramming;

// ============================================================================
//  322. Coin Change                                                   [Medium]
//  https://leetcode.com/problems/coin-change/
// ----------------------------------------------------------------------------
//  Return the fewest coins that add up to amount, or -1 if no combination
//  does. You have unlimited coins of each denomination.
//
//  Examples
//    coins = [1,2,5], amount = 11  ->  3
//    coins = [2], amount = 3  ->  -1
//    coins = [1], amount = 0  ->  0
//
//  Constraints
//    1 <= coins.Length <= 12
//    0 <= amount <= 10^4 on the examples, 100000 on the stress case
//
//  Hints (read only as many as you need)
//    1. Greedily taking the largest coin is wrong. Coins [1,3,4] and amount 6
//       is the classic counterexample.
//    2. Build up from 0: best[v] is the fewest coins making value v, and
//       best[0] is 0.
//    3. best[v] = 1 + min over coins c <= v of best[v-c]. Seed the array with
//       a sentinel above any real answer so unreachable values stay
//       recognisable.
//
//  Aim for O(amount * coins) time
// ============================================================================
[Problem(322)]
public sealed class CoinChange : ProblemTests<CoinChange>
{
    public int Solve(int[] coins, int amount)
    {
        throw new NotImplementedException();
    }
}
