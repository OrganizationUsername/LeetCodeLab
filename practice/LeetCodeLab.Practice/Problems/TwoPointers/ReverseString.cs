namespace LeetCodeLab.Practice.Problems.TwoPointers;

// ============================================================================
//  344. Reverse String                                                  [Easy]
//  https://leetcode.com/problems/reverse-string/
// ----------------------------------------------------------------------------
//  Reverse the character array in place using constant extra space. Nothing
//  is returned; the array itself is checked.
//
//  Examples
//    s = ["h","e","l","l","o"]  ->  s becomes ["o","l","l","e","h"]
//    s = ["H","a","n","n","a","h"]  ->  s becomes ["h","a","n","n","a","H"]
//
//  Constraints
//    1 <= s.Length <= 10^5
//
//  Hints (read only as many as you need)
//    1. One pointer at each end.
//    2. Swap the two characters, then step both pointers inward.
//    3. Stop when they meet or cross. Tuple assignment swaps without a
//       temporary.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(344)]
public sealed class ReverseString : ProblemTests<ReverseString>
{
    public void Solve(char[] s)
    {
        throw new NotImplementedException();
    }
}
