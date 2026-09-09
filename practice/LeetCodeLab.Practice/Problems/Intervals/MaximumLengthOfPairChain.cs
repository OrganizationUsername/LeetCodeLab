namespace LeetCodeLab.Practice.Problems.Intervals;

// ============================================================================
//  646. Maximum Length of Pair Chain                                  [Medium]
//  https://leetcode.com/problems/maximum-length-of-pair-chain/
// ----------------------------------------------------------------------------
//  Pair [a, b] may follow pair [c, d] when b < c, strictly. Choose pairs in
//  any order and return the length of the longest chain you can form.
//
//  Examples
//    pairs = [[1,2],[2,3],[3,4]]  ->  2
//    pairs = [[1,2],[7,8],[4,5]]  ->  3
//    pairs = [[1,2]]  ->  1
//
//  Constraints
//    1 <= pairs.Length <= 1000
//    each pair has a < b
//    pairs may be used in any order, not the order given
//    the follow condition is STRICT: [1,2] cannot be followed by [2,3]
//
//  Hints (read only as many as you need)
//    1. This is the same shape as scheduling non-overlapping activities: take
//       as many as possible, and the greedy rule is about which one to finish
//       first.
//    2. Sort by the SECOND value. Then walk the list taking any pair that
//       starts strictly after the last one you took ended.
//    3. Sorting by the first value instead needs dynamic programming to
//       recover the same answer; sorting by the end makes the greedy choice
//       provably safe, because finishing earliest leaves the most room.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(646)]
public sealed class MaximumLengthOfPairChain : ProblemTests<MaximumLengthOfPairChain>
{
    public int Solve(int[][] pairs)
    {
        throw new NotImplementedException();
    }
}
