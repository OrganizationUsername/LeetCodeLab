namespace LeetCodeLab.Practice.Problems.BitManipulation;

// ============================================================================
//  338. Counting Bits                                                   [Easy]
//  https://leetcode.com/problems/counting-bits/
// ----------------------------------------------------------------------------
//  Return an array of length n + 1 where entry i is the number of set bits in
//  i.
//
//  Examples
//    n = 2  ->  [0,1,1]
//    n = 5  ->  [0,1,1,2,1,2]
//    n = 0  ->  [0]
//
//  Constraints
//    0 <= n <= 10^5
//
//  Hints (read only as many as you need)
//    1. Calling a popcount routine for each i is O(n log n) and works.
//    2. For O(n), reuse answers you already have: i and i >> 1 differ only by
//       the lowest bit of i.
//    3. So result[i] = result[i >> 1] + (i & 1).
//
//  Aim for O(n) time
// ============================================================================
[Problem(338)]
public sealed class CountingBits : ProblemTests<CountingBits>
{
    public int[] Solve(int n)
    {
        throw new NotImplementedException();
    }
}
