namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  268. Missing Number                                                  [Easy]
//  https://leetcode.com/problems/missing-number/
// ----------------------------------------------------------------------------
//  The array holds n distinct values drawn from the range 0 to n inclusive,
//  so exactly one of them is absent. Return the missing value.
//
//  Examples
//    nums = [3,0,1]  ->  2
//    nums = [0,1]  ->  2
//    nums = [9,6,4,2,3,5,7,0,1]  ->  8
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    all values distinct and within 0..n
//
//  Hints (read only as many as you need)
//    1. Sorting or a HashSet both work.
//    2. For O(1) space, the sum 0+1+...+n has a closed form: n*(n+1)/2.
//       Subtract the actual sum.
//    3. XOR also works: XOR every index and every value together and the
//       survivor is the missing one.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(268)]
public sealed class MissingNumber : ProblemTests<MissingNumber>
{
    public int Solve(int[] nums)
    {
        throw new NotImplementedException();
    }
}
