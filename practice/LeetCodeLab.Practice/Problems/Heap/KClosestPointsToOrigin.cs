namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  973. K Closest Points to Origin                                    [Medium]
//  https://leetcode.com/problems/k-closest-points-to-origin/
// ----------------------------------------------------------------------------
//  Return the k points nearest the origin, measured by ordinary Euclidean
//  distance. The answer is unique for these cases, and may be returned in any
//  order.
//
//  Examples
//    points = [[1,3],[-2,2]], k = 1  ->  [[-2,2]]
//    points = [[3,3],[5,-1],[-2,4]], k = 2  ->  [[3,3],[-2,4]]
//    points = [[0,1],[1,0]], k = 2  ->  [[0,1],[1,0]]
//
//  Constraints
//    1 <= k <= points.Length <= 10^4
//    -10^4 <= coordinates <= 10^4
//
//  Hints (read only as many as you need)
//    1. Comparing squared distances is enough. Taking a square root changes
//       nothing about the ordering and only costs precision.
//    2. Sorting by squared distance and taking the first k is O(n log n) and
//       passes.
//    3. A max-heap capped at size k gives O(n log k), and quickselect gives
//       average O(n).
//
//  Aim for O(n log k) with a heap
// ============================================================================
[Problem(973)]
public sealed class KClosestPointsToOrigin : ProblemTests<KClosestPointsToOrigin>
{
    public int[][] Solve(int[][] points, int k)
    {
        throw new NotImplementedException();
    }
}
