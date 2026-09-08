namespace LeetCodeLab.Verify.Reference;

[Problem(98)]
public sealed class ValidateBinarySearchTree : ProblemTests<ValidateBinarySearchTree>
{
    public bool Solve(TreeNode? root) => Check(root, long.MinValue, long.MaxValue);

    private static bool Check(TreeNode? node, long low, long high) =>
        node is null
        || (node.val > low && node.val < high
            && Check(node.left, low, node.val)
            && Check(node.right, node.val, high));
}

[Problem(100)]
public sealed class SameTree : ProblemTests<SameTree>
{
    public bool Solve(TreeNode? p, TreeNode? q)
    {
        if (p is null || q is null) return p is null && q is null;
        return p.val == q.val && Solve(p.left, q.left) && Solve(p.right, q.right);
    }
}

[Problem(102)]
public sealed class BinaryTreeLevelOrderTraversal : ProblemTests<BinaryTreeLevelOrderTraversal>
{
    public IList<IList<int>> Solve(TreeNode? root)
    {
        List<IList<int>> levels = [];
        if (root is null) return levels;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int width = queue.Count;
            List<int> level = [];
            for (int i = 0; i < width; i++)
            {
                TreeNode node = queue.Dequeue();
                level.Add(node.val);
                if (node.left is not null) queue.Enqueue(node.left);
                if (node.right is not null) queue.Enqueue(node.right);
            }
            levels.Add(level);
        }
        return levels;
    }
}

[Problem(104)]
public sealed class MaximumDepthOfBinaryTree : ProblemTests<MaximumDepthOfBinaryTree>
{
    public int Solve(TreeNode? root) =>
        root is null ? 0 : 1 + Math.Max(Solve(root.left), Solve(root.right));
}

[Problem(226)]
public sealed class InvertBinaryTree : ProblemTests<InvertBinaryTree>
{
    public TreeNode? Solve(TreeNode? root)
    {
        if (root is null) return null;
        (root.left, root.right) = (Solve(root.right), Solve(root.left));
        return root;
    }
}

[Problem(230)]
public sealed class KthSmallestElementInABst : ProblemTests<KthSmallestElementInABst>
{
    public int Solve(TreeNode? root, int k)
    {
        Stack<TreeNode> stack = new();
        TreeNode? node = root;
        while (node is not null || stack.Count > 0)
        {
            while (node is not null) { stack.Push(node); node = node.left; }
            node = stack.Pop();
            if (--k == 0) return node.val;
            node = node.right;
        }
        return -1;
    }
}

[Problem(572)]
public sealed class SubtreeOfAnotherTree : ProblemTests<SubtreeOfAnotherTree>
{
    public bool Solve(TreeNode? root, TreeNode? subRoot)
    {
        if (root is null) return subRoot is null;
        return TreeNodes.Equal(root, subRoot)
            || Solve(root.left, subRoot)
            || Solve(root.right, subRoot);
    }
}
