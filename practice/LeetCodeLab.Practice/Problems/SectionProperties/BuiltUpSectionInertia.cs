namespace LeetCodeLab.Practice.Problems.SectionProperties;

// ============================================================================
//  9002. Built-Up Section Inertia                                     [Medium]
// ----------------------------------------------------------------------------
//  A plate girder is built up from rectangles, each given as [x, y, width,
//  height] where (x, y) is its lower-left corner. Return [area, ybar, Ixx]:
//  the total area, the height of the combined centroid above y = 0, and the
//  second moment of area about the horizontal axis through THAT centroid. The
//  rectangles do not overlap.
//
//  Examples
//    rectangles = [[0,0,2,10]]  ->  [20,5,166.66666667]
//    rectangles = [[0,0,8,1],[3.5,1,1,10],[0,11,8,1]]  ->  [26,6,568.66666667]
//    rectangles = [[0,0,4,2],[0,2,2,6]]  ->  [20,3.4,115.46666667]
//
//  Constraints
//    1 <= rectangles.Length <= 100
//    width > 0 and height > 0
//    rectangles do not overlap
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Area and ybar first: ybar is the area-weighted average of the
//       individual centroid heights, not the average of the heights.
//    2. For Ixx you cannot just add each rectangle's own b*h^3/12, because
//       those are measured about each rectangle's OWN centroid, and the
//       answer is wanted about the combined one.
//    3. Parallel axis theorem: a piece of area A whose centroid sits a
//       distance d from the reference axis contributes I_own + A*d^2. So
//       compute ybar first, then sum b*h^3/12 + A*(yc - ybar)^2 over the
//       pieces.
//
//  Aim for O(n) time, O(1) space
// ============================================================================
[Problem(9002)]
public sealed class BuiltUpSectionInertia : ProblemTests<BuiltUpSectionInertia>
{
    public double[] Solve(double[][] rectangles)
    {
        throw new NotImplementedException();
    }
}
