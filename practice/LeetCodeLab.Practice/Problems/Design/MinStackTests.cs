namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  155. Min Stack                                                     [Medium]
//  https://leetcode.com/problems/min-stack/
// ----------------------------------------------------------------------------
//  A stack that also reports its minimum. Push, Pop, Top and GetMin must all
//  be O(1). Pop and Top are only called on a non-empty stack.
//
//  Examples
//    MinStack, push, push, push, getMin, pop, top, getMin
//      with [[],[-2],[0],[-3],[],[],[],[]]
//      ->   [null,null,null,null,-3,null,0,-2]
//
//  Constraints
//    up to 3*10^4 calls
//    values fit in a 32-bit integer
//
//  Hints (read only as many as you need)
//    1. Scanning for the minimum on demand is O(n), so the minimum has to be
//       maintained as you go.
//    2. A single minimum variable fails: popping the minimum leaves you with
//       no idea what the new one is.
//    3. Keep a second stack holding the minimum as of each push. Push
//       min(value, current minimum) alongside every value and pop both
//       together.
//
//  Aim for O(1) per operation
// ============================================================================
[Problem(155, Target = typeof(MinStack))]
public sealed class MinStackTests : ProblemTests<MinStackTests>;

public class MinStack
{
    public MinStack()
    {
        throw new NotImplementedException();
    }

    public void Push(int val)
    {
        throw new NotImplementedException();
    }

    public void Pop()
    {
        throw new NotImplementedException();
    }

    public int Top()
    {
        throw new NotImplementedException();
    }

    public int GetMin()
    {
        throw new NotImplementedException();
    }
}
