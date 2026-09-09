using System.Text.Json;

namespace LeetCodeLab.Practice.Problems.Trees;

// ============================================================================
//  108. Convert Sorted Array to Binary Search Tree                      [Easy]
//  https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
// ----------------------------------------------------------------------------
//  The array is sorted ascending. Build a height-balanced binary search tree
//  from it. Several trees are valid and any height-balanced one is accepted.
//
//  Examples
//    nums = [-10,-3,0,5,9]  ->  [0,-3,9,-10,null,5]  (other answers may also be accepted)
//    nums = [1,3]  ->  [3,1]  (other answers may also be accepted)
//    nums = [1]  ->  [1]  (other answers may also be accepted)
//
//  Constraints
//    1 <= nums.Length <= 10^4
//    nums is sorted strictly ascending
//
//  Hints (read only as many as you need)
//    1. Balance comes from splitting evenly, so make the MIDDLE element the
//       root.
//    2. Everything left of it becomes the left subtree, everything right
//       becomes the right subtree, recursively.
//    3. Both the lower and the upper middle are acceptable for an even-length
//       slice, which is why several answers pass.
//
//  Aim for O(n) time, O(log n) space
// ============================================================================
[Problem(108)]
public sealed class SortedArrayToBst : ProblemTests<SortedArrayToBst>
{
    public TreeNode? Solve(int[] nums)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Harness plumbing: many height-balanced BSTs are correct, so this checks the two
    /// properties instead of comparing against one particular tree.
    /// </summary>
    public static bool Validate(object?[] args, object? actual, JsonElement expected)
    {
        int[] nums = (int[])args[0]!;
        TreeNode? root = actual as TreeNode;

        List<int> inorder = [];
        void Walk(TreeNode? node)
        {
            if (node is null) return;
            Walk(node.left);
            inorder.Add(node.val);
            Walk(node.right);
        }
        Walk(root);
        if (!inorder.SequenceEqual(nums)) return false;

        static int Height(TreeNode? node)
        {
            if (node is null) return 0;
            int left = Height(node.left), right = Height(node.right);
            if (left < 0 || right < 0 || Math.Abs(left - right) > 1) return -1;
            return 1 + Math.Max(left, right);
        }
        return Height(root) >= 0;
    }
}
