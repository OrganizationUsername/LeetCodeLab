namespace LeetCodeLab.Core;

/// <summary>Binary tree node, matching LeetCode's declaration exactly.</summary>
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override string ToString() => "[" + string.Join(",",
        TreeNodes.ToLevelOrder(this).Select(v => v?.ToString() ?? "null")) + "]";
}

public static class TreeNodes
{
    /// <summary>
    /// Builds a tree from LeetCode's level-order form, e.g. [3,9,20,null,null,15,7].
    /// Children of a null slot are omitted from the array rather than padded.
    /// </summary>
    public static TreeNode? FromLevelOrder(IReadOnlyList<int?> values)
    {
        if (values.Count == 0 || values[0] is null) return null;

        TreeNode root = new(values[0]!.Value);
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int i = 1;

        while (queue.Count > 0 && i < values.Count)
        {
            TreeNode node = queue.Dequeue();

            if (i < values.Count)
            {
                if (values[i] is int l) { node.left = new TreeNode(l); queue.Enqueue(node.left); }
                i++;
            }
            if (i < values.Count)
            {
                if (values[i] is int r) { node.right = new TreeNode(r); queue.Enqueue(node.right); }
                i++;
            }
        }
        return root;
    }

    /// <summary>Serialises back to LeetCode's level-order form, with trailing nulls trimmed.</summary>
    public static List<int?> ToLevelOrder(TreeNode? root)
    {
        List<int?> result = [];
        if (root is null) return result;

        Queue<TreeNode?> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode? node = queue.Dequeue();
            if (node is null) { result.Add(null); continue; }
            result.Add(node.val);
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        while (result.Count > 0 && result[^1] is null) result.RemoveAt(result.Count - 1);
        return result;
    }

    /// <summary>Structural equality by shape and value.</summary>
    public static bool Equal(TreeNode? a, TreeNode? b)
    {
        if (a is null || b is null) return a is null && b is null;
        return a.val == b.val && Equal(a.left, b.left) && Equal(a.right, b.right);
    }

    /// <summary>Finds the first node with the given value - LCA problems pass node values as input.</summary>
    public static TreeNode? Find(TreeNode? root, int val)
    {
        if (root is null) return null;
        if (root.val == val) return root;
        return Find(root.left, val) ?? Find(root.right, val);
    }
}
