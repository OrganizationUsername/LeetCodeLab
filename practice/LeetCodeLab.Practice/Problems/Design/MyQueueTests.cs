namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  232. Implement Queue using Stacks                                    [Easy]
//  https://leetcode.com/problems/implement-queue-using-stacks/
// ----------------------------------------------------------------------------
//  Build a first-in-first-out queue using only stack operations: push, pop,
//  peek, size and empty. Each operation should be O(1) amortised.
//
//  Examples
//    MyQueue, Push, Push, Peek, Pop, Empty
//      with [[],[1],[2],[],[],[]]
//      ->   [null,null,null,1,1,false]
//
//  Constraints
//    1 <= x <= 9
//    at most 100 calls
//    pop and peek are only called on a non-empty queue
//
//  Hints (read only as many as you need)
//    1. A single stack gives you the wrong order, so use two: an inbox and an
//       outbox.
//    2. Push always goes onto the inbox. Pop and peek always come off the
//       outbox.
//    3. When the outbox is empty, tip the entire inbox into it, which
//       reverses the order exactly once. Never tip while the outbox still has
//       items, or you will interleave the order. Each element moves at most
//       twice, which is what makes it amortised O(1).
//
//  Aim for amortised O(1) per operation
// ============================================================================
[Problem(232, Target = typeof(MyQueue))]
public sealed class MyQueueTests : ProblemTests<MyQueueTests>;

public class MyQueue
{
    public MyQueue()
    {
        throw new NotImplementedException();
    }

    public void Push(int x)
    {
        throw new NotImplementedException();
    }

    public int Pop()
    {
        throw new NotImplementedException();
    }

    public int Peek()
    {
        throw new NotImplementedException();
    }

    public bool Empty()
    {
        throw new NotImplementedException();
    }
}
