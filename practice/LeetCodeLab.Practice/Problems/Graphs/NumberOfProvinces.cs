namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  547. Number of Provinces                                           [Medium]
//  https://leetcode.com/problems/number-of-provinces/
// ----------------------------------------------------------------------------
//  isConnected is an adjacency matrix over n cities, where entry [i][j] is 1
//  when city i and city j are directly connected. A province is a maximal
//  group of cities all reachable from each other. Return how many provinces
//  there are.
//
//  Examples
//    isConnected = [[1,1,0],[1,1,0],[0,0,1]]  ->  2
//    isConnected = [[1,0,0],[0,1,0],[0,0,1]]  ->  3
//    isConnected = [[1,1,1],[1,1,1],[1,1,1]]  ->  1
//
//  Constraints
//    1 <= n <= 200
//    the matrix is symmetric with 1s on the diagonal
//
//  Hints (read only as many as you need)
//    1. This is counting connected components, the same shape as Number of
//       Islands but on an explicit graph.
//    2. Keep a visited array. For each unvisited city, increment the counter
//       and flood everything reachable from it.
//    3. Union-Find also solves it neatly: union every connected pair, then
//       count distinct roots.
//
//  Aim for O(n^2) time
// ============================================================================
[Problem(547)]
public sealed class NumberOfProvinces : ProblemTests<NumberOfProvinces>
{
    public int Solve(int[][] isConnected)
    {
        throw new NotImplementedException();
    }
}
