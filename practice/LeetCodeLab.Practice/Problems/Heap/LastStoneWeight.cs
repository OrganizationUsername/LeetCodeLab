namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  1046. Last Stone Weight                                              [Easy]
//  https://leetcode.com/problems/last-stone-weight/
// ----------------------------------------------------------------------------
//  Repeatedly smash the two heaviest stones together. Equal stones destroy
//  each other; otherwise the heavier one survives with the weight difference.
//  Return the weight of the last stone, or 0 if none remain.
//
//  Examples
//    stones = [2,7,4,1,8,1]  ->  1
//    stones = [1]  ->  1
//    stones = [2,2]  ->  0
//
//  Constraints
//    1 <= stones.Length <= 30
//    1 <= stones[i] <= 1000
//
//  Hints (read only as many as you need)
//    1. You need the two largest values repeatedly, and the set changes after
//       each smash.
//    2. That is exactly a max-heap. C# PriorityQueue is a min-heap, so
//       enqueue with a negated priority.
//    3. Loop while more than one stone remains, popping two and pushing the
//       difference back when it is non-zero.
//
//  Aim for O(n log n) time
// ============================================================================
[Problem(1046)]
public sealed class LastStoneWeight : ProblemTests<LastStoneWeight>
{
    public int Solve(int[] stones)
    {
        throw new NotImplementedException();
    }
}
