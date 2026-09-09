namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  703. Kth Largest Element in a Stream                                 [Easy]
//  https://leetcode.com/problems/kth-largest-element-in-a-stream/
// ----------------------------------------------------------------------------
//  The constructor takes k and a starting array. Each Add inserts a value and
//  returns the kth largest element in the collection at that moment, counting
//  duplicates.
//
//  Examples
//    KthLargest, add, add, add, add, add
//      with [[3,[4,5,8,2]],[3],[5],[10],[9],[4]]
//      ->   [null,4,5,5,8,8]
//
//  Constraints
//    1 <= k <= 10^4
//    the collection always has at least k elements when Add returns
//
//  Hints (read only as many as you need)
//    1. You never need the whole collection sorted, only the k largest of it.
//    2. Keep a min-heap holding exactly those k largest. Its root is the kth
//       largest, which is the answer.
//    3. On each add, push and then drop the smallest while the heap exceeds
//       size k. Run the constructor array through the same Add path rather
//       than duplicating logic.
//
//  Aim for O(log k) per add
// ============================================================================
[Problem(703, Target = typeof(KthLargest))]
public sealed class KthLargestTests : ProblemTests<KthLargestTests>;

public class KthLargest
{
    public KthLargest(int k, int[] nums)
    {
        throw new NotImplementedException();
    }

    public int Add(int val)
    {
        throw new NotImplementedException();
    }
}
