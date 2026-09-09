namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  71. Simplify Path                                                  [Medium]
//  https://leetcode.com/problems/simplify-path/
// ----------------------------------------------------------------------------
//  Turn an absolute Unix-style path into its canonical form. A single dot
//  means the current directory, two dots means go up one level, and any run
//  of slashes counts as one. The result starts with a slash, never ends with
//  one unless it is the root, and contains no dot segments.
//
//  Examples
//    path = "/home/"  ->  "/home"
//    path = "/../"  ->  "/"
//    path = "/home//foo/"  ->  "/home/foo"
//
//  Constraints
//    1 <= path.Length <= 3000
//    the path is absolute, so it always begins with a slash
//    going up from the root stays at the root
//    a name may legitimately contain dots, such as ... or a.b
//
//  Hints (read only as many as you need)
//    1. Split on the slash and work through the pieces. Empty pieces come
//       from repeated slashes and are simply skipped.
//    2. Keep the surviving directory names on a stack: a name pushes, .. pops
//       if anything is there, and . does nothing.
//    3. Popping an empty stack must be a no-op rather than an error, since ..
//       at the root is legal. And only exactly "." and ".." are special - a
//       segment of three dots is an ordinary directory name.
//
//  Aim for O(n) time and space
// ============================================================================
[Problem(71)]
public sealed class SimplifyPath : ProblemTests<SimplifyPath>
{
    public string Solve(string path)
    {
        throw new NotImplementedException();
    }
}
