using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  210. Course Schedule II                                            [Medium]
//  https://leetcode.com/problems/course-schedule-ii/
// ----------------------------------------------------------------------------
//  Each entry [a, b] means b must be taken before a. Return any ordering of
//  all the courses that respects every prerequisite, or an empty array when
//  no such ordering exists.
//
//  Examples
//    numCourses = 2, prerequisites = [[1,0]]  ->  [0,1]  (other answers may also be accepted)
//    numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]  ->  [0,1,2,3]  (other answers may also be accepted)
//    numCourses = 1, prerequisites = []  ->  [0]  (other answers may also be accepted)
//
//  Constraints
//    1 <= numCourses <= 2000
//    0 <= prerequisites.Length <= numCourses*(numCourses-1)
//
//  Hints (read only as many as you need)
//    1. Same graph as Course Schedule, but now you must produce the order
//       rather than just a yes or no.
//    2. Kahn topological sort gives it directly: repeatedly take a course
//       with no remaining prerequisites and append it to the output.
//    3. If the output is shorter than numCourses when the queue empties, a
//       cycle blocked you, so return an empty array.
//
//  Aim for O(V + E) time
// ============================================================================
[Problem(210)]
public sealed class CourseScheduleII : ProblemTests<CourseScheduleII>
{
    public int[] Solve(int numCourses, int[][] prerequisites)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Harness plumbing: any ordering that respects every prerequisite is accepted.
    /// An unsolvable case must return an empty array.
    /// </summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int numCourses = (int)args[0]!;
        int[][] prerequisites = (int[][])args[1]!;
        if (actual is not int[] order) return false;

        if (expected.GetArrayLength() == 0) return order.Length == 0;
        if (order.Length != numCourses) return false;

        int[] position = new int[numCourses];
        bool[] seen = new bool[numCourses];
        for (int i = 0; i < order.Length; i++)
        {
            int course = order[i];
            if (course < 0 || course >= numCourses || seen[course]) return false;
            seen[course] = true;
            position[course] = i;
        }

        foreach (int[] edge in prerequisites)
            if (position[edge[1]] > position[edge[0]]) return false;

        return true;
    }
}
