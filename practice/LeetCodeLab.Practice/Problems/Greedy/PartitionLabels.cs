namespace LeetCodeLab.Practice.Problems.Greedy;

// ============================================================================
//  763. Partition Labels                                              [Medium]
//  https://leetcode.com/problems/partition-labels/
// ----------------------------------------------------------------------------
//  Cut the string into as many pieces as possible so that no letter appears
//  in more than one piece. Return the piece lengths in order.
//
//  Examples
//    s = "ababcbacadefegdehijhklij"  ->  [9,7,8]
//    s = "eccbbbbdec"  ->  [10]
//    s = "abc"  ->  [1,1,1]
//
//  Constraints
//    1 <= s.Length <= 500
//    lowercase English letters
//
//  Hints (read only as many as you need)
//    1. A piece cannot end before the LAST occurrence of every letter it
//       contains.
//    2. So first record the last index of each letter in one pass.
//    3. Then sweep, extending the current piece end to the furthest
//       last-occurrence seen so far. When the scan index reaches that end,
//       the piece closes.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(763)]
public sealed class PartitionLabels : ProblemTests<PartitionLabels>
{
    public IList<int> Solve(string s)
    {
        throw new NotImplementedException();
    }
}
