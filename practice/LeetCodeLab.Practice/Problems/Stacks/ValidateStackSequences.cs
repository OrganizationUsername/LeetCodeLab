namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  946. Validate Stack Sequences                                      [Medium]
//  https://leetcode.com/problems/validate-stack-sequences/
// ----------------------------------------------------------------------------
//  Both arrays are permutations of the same distinct values. Decide whether
//  some interleaving of pushes and pops on an initially empty stack produces
//  exactly these push and pop orders.
//
//  Examples
//    pushed = [1,2,3,4,5], popped = [4,5,3,2,1]  ->  true
//    pushed = [1,2,3,4,5], popped = [4,3,5,1,2]  ->  false
//    pushed = [1], popped = [1]  ->  true
//
//  Constraints
//    1 <= pushed.Length <= 1000
//    popped is a permutation of pushed and all values are distinct
//    pushes must happen in the order given, and so must pops
//
//  Hints (read only as many as you need)
//    1. You do not need to search over interleavings. At every moment there
//       is only one sensible move.
//    2. Simulate: push the next value, then pop greedily for as long as the
//       stack top matches the next value expected in popped.
//    3. Greedy is safe because if the top matches the next expected pop and
//       you do not take it, it is buried forever. At the end the sequence is
//       valid exactly when the stack has emptied.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(946)]
public sealed class ValidateStackSequences : ProblemTests<ValidateStackSequences>
{
    public bool Solve(int[] pushed, int[] popped)
    {
        throw new NotImplementedException();
    }
}
