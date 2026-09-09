namespace LeetCodeLab.Practice.Problems.Heap;

// ============================================================================
//  378. Kth Smallest Element in a Sorted Matrix                       [Medium]
//  https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/
// ----------------------------------------------------------------------------
//  Each row is sorted ascending and each column is sorted ascending. Return
//  the kth smallest value in the whole matrix, counting duplicates separately
//  rather than as one value.
//
//  Examples
//    matrix = [[1,5,9],[10,11,13],[12,13,15]], k = 8  ->  13
//    matrix = [[-5]], k = 1  ->  -5
//    matrix = [[1,2],[1,3]], k = 1  ->  1
//
//  Constraints
//    1 <= n <= 300, the matrix is n by n
//    rows and columns are each sorted ascending
//    1 <= k <= n*n
//    duplicates count individually, so the 2nd smallest of [1,1] is 1
//
//  Hints (read only as many as you need)
//    1. Flattening and sorting is O(n^2 log n) and throws away the ordering
//       you were given. Use it.
//    2. Merge the n sorted rows with a min-heap seeded by the first element
//       of each row; pop k times, pushing the next element of whichever row
//       you popped from.
//    3. There is a better one: binary search on the ANSWER VALUE rather than
//       on a position. For a candidate value, count how many entries are less
//       than or equal to it by walking the staircase from the bottom-left in
//       O(n). That gives O(n log(range)) and no heap at all.
//
//  Aim for O(k log n) with a heap, O(n log(range)) with binary search
// ============================================================================
[Problem(378)]
public sealed class KthSmallestInSortedMatrix : ProblemTests<KthSmallestInSortedMatrix>
{
    public int Solve(int[][] matrix, int k)
    {
        throw new NotImplementedException();
    }
}
