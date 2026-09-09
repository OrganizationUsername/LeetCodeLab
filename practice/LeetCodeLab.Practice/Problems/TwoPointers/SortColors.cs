namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  75. Sort Colors                                                    [Medium]
//  https://leetcode.com/problems/sort-colors/
// ----------------------------------------------------------------------------
//  The array holds only 0, 1 and 2, representing red, white and blue. Sort it
//  in place in a single pass without using a library sort.
//
//  Examples
//    nums = [2,0,2,1,1,0]  ->  nums becomes [0,0,1,1,2,2]
//    nums = [2,0,1]  ->  nums becomes [0,1,2]
//    nums = [0]  ->  nums becomes [0]
//
//  Constraints
//    1 <= nums.Length <= 300
//    nums[i] is 0, 1 or 2
//
//  Hints (read only as many as you need)
//    1. Counting how many of each value and rewriting the array is two passes
//       and perfectly valid.
//    2. For one pass, keep three regions: settled 0s at the front, settled 2s
//       at the back, and 1s in the middle.
//    3. This is the Dutch national flag partition: a low pointer, a high
//       pointer, and a scanner. On a 2 you swap to the back but must NOT
//       advance the scanner, since the swapped-in value is unexamined.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(75)]
public sealed class SortColors : ProblemTests<SortColors>
{
    public void Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
