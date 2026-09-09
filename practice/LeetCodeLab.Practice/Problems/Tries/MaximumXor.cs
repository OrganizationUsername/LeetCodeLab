namespace LeetCodeLab.Practice.Problems.Tries;

// ============================================================================
//  421. Maximum XOR of Two Numbers in an Array                        [Medium]
//  https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array/
// ----------------------------------------------------------------------------
//  Return the largest value of nums[i] XOR nums[j] over all pairs of
//  positions, where i and j may be the same position. With a single element
//  the answer is therefore 0.
//
//  Examples
//    nums = [3,10,5,25,2,8]  ->  28
//    nums = [0]  ->  0
//    nums = [2,4]  ->  6
//
//  Constraints
//    1 <= nums.Length <= 2*10^5
//    0 <= nums[i] < 2^31
//    i and j may be equal, so a one-element array answers 0
//    the quadratic double loop is too slow at the upper size
//
//  Hints (read only as many as you need)
//    1. To make a XOR large you want the highest bits to DIFFER. That is a
//       prefix-matching question, which is what a trie is for.
//    2. Insert every number as a path of 31 bits, most significant first.
//       Then for each number, walk down preferring the OPPOSITE bit at every
//       step, taking the same bit only when the opposite branch is absent.
//    3. That greedy descent is optimal because a higher bit outweighs every
//       lower bit combined. There is also a neat hash-set solution: build the
//       answer bit by bit from the top, and at each step ask whether some
//       pair of observed prefixes XORs to the candidate.
//
//  Aim for O(31n) time
// ============================================================================
[Problem(421)]
public sealed class MaximumXor : ProblemTests<MaximumXor>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
