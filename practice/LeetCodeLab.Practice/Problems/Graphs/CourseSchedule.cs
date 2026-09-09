namespace LeetCodeLab.Practice.Problems.Graphs;

// ============================================================================
//  207. Course Schedule                                               [Medium]
//  https://leetcode.com/problems/course-schedule/
// ----------------------------------------------------------------------------
//  Each entry [a, b] means you must take b before a. Return true when some
//  ordering lets you finish every course, which is exactly the question of
//  whether the dependency graph is free of cycles.
//
//  Examples
//    numCourses = 2, prerequisites = [[1,0]]  ->  true
//    numCourses = 2, prerequisites = [[1,0],[0,1]]  ->  false
//    numCourses = 5, prerequisites = [[1,4],[2,4],[3,1],[3,2]]  ->  true
//
//  Constraints
//    1 <= numCourses <= 2000
//    0 <= prerequisites.Length <= 5000
//
//  Hints (read only as many as you need)
//    1. Model it as a directed graph with an edge from b to a, then ask
//       whether it has a cycle.
//    2. Kahn topological sort: count incoming edges per course, queue
//       everything with zero, and remove them one by one.
//    3. If you manage to remove all numCourses nodes there was no cycle.
//       Anything left over is stuck in one.
//
//  Aim for O(V + E) time
// ============================================================================
[Problem(207)]
public sealed class CourseSchedule : ProblemTests<CourseSchedule>
{
    public bool Solve(int numCourses, int[][] prerequisites)
    {
        throw new NotImplementedException();
    }
}
