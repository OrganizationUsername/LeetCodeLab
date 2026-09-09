namespace LeetCodeLab.Practice.Problems.Design;

// ============================================================================
//  295. Find Median from Data Stream                                    [Hard]
//  https://leetcode.com/problems/find-median-from-data-stream/
// ----------------------------------------------------------------------------
//  Numbers arrive one at a time. FindMedian returns the median of everything
//  added so far: the middle value for an odd count, the average of the two
//  middle values for an even count. Sorting on every query is too slow.
//
//  Examples
//    MedianFinder, addNum, addNum, findMedian, addNum, findMedian
//      with [[],[1],[2],[],[3],[]]
//      ->   [null,null,null,1.5,null,2.0]
//
//  Constraints
//    -10^5 <= num <= 10^5
//    FindMedian is only called after at least one AddNum
//
//  Hints (read only as many as you need)
//    1. Keep the values split into a smaller half and a larger half, sized
//       equally or with one extra in the smaller half.
//    2. Store the smaller half in a max-heap and the larger half in a
//       min-heap. The median is then read off one or both roots.
//    3. Always push into one heap and move its extreme across to the other,
//       then rebalance sizes. C# PriorityQueue is a min-heap, so negate the
//       priority to build a max-heap.
//
//  Aim for O(log n) per add, O(1) per query
// ============================================================================
[Problem(295, Target = typeof(MedianFinder))]
public sealed class MedianFinderTests : ProblemTests<MedianFinderTests>;

public class MedianFinder
{
    public MedianFinder()
    {
        throw new NotImplementedException();
    }

    public void AddNum(int num)
    {
        throw new NotImplementedException();
    }

    public double FindMedian()
    {
        throw new NotImplementedException();
    }
}
