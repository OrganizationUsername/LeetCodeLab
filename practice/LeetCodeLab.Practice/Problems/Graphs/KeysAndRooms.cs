namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  841. Keys and Rooms                                                [Medium]
//  https://leetcode.com/problems/keys-and-rooms/
// ----------------------------------------------------------------------------
//  There are n rooms numbered 0 to n-1, all locked except room 0. rooms[i]
//  lists the keys found in room i, each opening the room of that number.
//  Starting in room 0, return whether you can get into every room.
//
//  Examples
//    rooms = [[1],[2],[3],[]]  ->  true
//    rooms = [[1,3],[3,0,1],[2],[0]]  ->  false
//    rooms = [[1],[]]  ->  true
//
//  Constraints
//    2 <= rooms.Length <= 1000
//    a key may appear more than once and may open a room you have already entered
//    room 0 starts unlocked
//
//  Hints (read only as many as you need)
//    1. This is reachability from node 0, with keys as directed edges. The
//       rooms you can enter are exactly the nodes you can reach.
//    2. Depth-first or breadth-first from room 0, marking rooms as you enter
//       them, then check whether the count of entered rooms equals the total.
//    3. Duplicate keys are the trap: without a visited check you will revisit
//       rooms forever on a cyclic key layout. Mark on entry, not on exit.
//
//  Aim for O(rooms + keys) time
// ============================================================================
[Problem(841)]
public sealed class KeysAndRooms : ProblemTests<KeysAndRooms>
{
    public bool Solve(int[][] rooms)
    {
        throw new NotImplementedException();
    }
}
