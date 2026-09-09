namespace LeetCodeLab.Verify.Reference;

[Problem(110)]
public sealed class BalancedBinaryTree : ProblemTests<BalancedBinaryTree>
{
    public bool Solve(TreeNode? root) => Height(root) >= 0;

    // -1 means "already unbalanced below here" and propagates straight up.
    private static int Height(TreeNode? node)
    {
        if (node is null) return 0;
        int left = Height(node.left);
        if (left < 0) return -1;
        int right = Height(node.right);
        if (right < 0 || Math.Abs(left - right) > 1) return -1;
        return 1 + Math.Max(left, right);
    }
}

[Problem(543)]
public sealed class DiameterOfBinaryTree : ProblemTests<DiameterOfBinaryTree>
{
    public int Solve(TreeNode? root)
    {
        int best = 0;

        int Height(TreeNode? node)
        {
            if (node is null) return 0;
            int left = Height(node.left), right = Height(node.right);
            best = Math.Max(best, left + right);
            return 1 + Math.Max(left, right);
        }

        Height(root);
        return best;
    }
}

[Problem(199)]
public sealed class BinaryTreeRightSideView : ProblemTests<BinaryTreeRightSideView>
{
    public IList<int> Solve(TreeNode? root)
    {
        List<int> view = [];
        if (root is null) return view;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int width = queue.Count;
            for (int i = 0; i < width; i++)
            {
                TreeNode node = queue.Dequeue();
                if (i == width - 1) view.Add(node.val);
                if (node.left is not null) queue.Enqueue(node.left);
                if (node.right is not null) queue.Enqueue(node.right);
            }
        }
        return view;
    }
}

[Problem(101)]
public sealed class SymmetricTree : ProblemTests<SymmetricTree>
{
    public bool Solve(TreeNode? root) => Mirror(root?.left, root?.right);

    private static bool Mirror(TreeNode? a, TreeNode? b)
    {
        if (a is null || b is null) return a is null && b is null;
        return a.val == b.val && Mirror(a.left, b.right) && Mirror(a.right, b.left);
    }
}

[Problem(112)]
public sealed class PathSum : ProblemTests<PathSum>
{
    public bool Solve(TreeNode? root, int targetSum)
    {
        if (root is null) return false;
        int remaining = targetSum - root.val;
        if (root.left is null && root.right is null) return remaining == 0;
        return Solve(root.left, remaining) || Solve(root.right, remaining);
    }
}

[Problem(111)]
public sealed class MinimumDepthOfBinaryTree : ProblemTests<MinimumDepthOfBinaryTree>
{
    public int Solve(TreeNode? root)
    {
        if (root is null) return 0;
        if (root.left is null) return 1 + Solve(root.right);
        if (root.right is null) return 1 + Solve(root.left);
        return 1 + Math.Min(Solve(root.left), Solve(root.right));
    }
}

[Problem(617)]
public sealed class MergeTwoBinaryTrees : ProblemTests<MergeTwoBinaryTrees>
{
    public TreeNode? Solve(TreeNode? root1, TreeNode? root2)
    {
        if (root1 is null) return root2;
        if (root2 is null) return root1;
        return new TreeNode(root1.val + root2.val,
            Solve(root1.left, root2.left),
            Solve(root1.right, root2.right));
    }
}

[Problem(105)]
public sealed class ConstructTreeFromPreorderInorder : ProblemTests<ConstructTreeFromPreorderInorder>
{
    public TreeNode? Solve(int[] preorder, int[] inorder)
    {
        Dictionary<int, int> position = [];
        for (int i = 0; i < inorder.Length; i++) position[inorder[i]] = i;

        int next = 0;

        TreeNode? Build(int lo, int hi)
        {
            if (lo > hi) return null;
            int value = preorder[next++];
            int mid = position[value];
            TreeNode node = new(value);
            node.left = Build(lo, mid - 1);
            node.right = Build(mid + 1, hi);
            return node;
        }

        return Build(0, inorder.Length - 1);
    }
}

[Problem(124)]
public sealed class BinaryTreeMaximumPathSum : ProblemTests<BinaryTreeMaximumPathSum>
{
    public int Solve(TreeNode? root)
    {
        int best = int.MinValue;

        // Returns the best downward-only branch; records the best turning path.
        int Branch(TreeNode? node)
        {
            if (node is null) return 0;
            int left = Math.Max(0, Branch(node.left));
            int right = Math.Max(0, Branch(node.right));
            best = Math.Max(best, node.val + left + right);
            return node.val + Math.Max(left, right);
        }

        Branch(root);
        return best;
    }
}

[Problem(2)]
public sealed class AddTwoNumbers : ProblemTests<AddTwoNumbers>
{
    public ListNode? Solve(ListNode? l1, ListNode? l2)
    {
        ListNode dummy = new();
        ListNode tail = dummy;
        int carry = 0;

        while (l1 is not null || l2 is not null || carry != 0)
        {
            int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
            carry = sum / 10;
            tail.next = new ListNode(sum % 10);
            tail = tail.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return dummy.next;
    }
}

[Problem(234)]
public sealed class PalindromeLinkedList : ProblemTests<PalindromeLinkedList>
{
    public bool Solve(ListNode? head)
    {
        ListNode? slow = head, fast = head;
        while (fast?.next is not null) { slow = slow!.next; fast = fast.next.next; }

        ListNode? previous = null;
        while (slow is not null)
        {
            ListNode? next = slow.next;
            slow.next = previous;
            previous = slow;
            slow = next;
        }

        while (previous is not null && head is not null)
        {
            if (previous.val != head.val) return false;
            previous = previous.next;
            head = head.next;
        }
        return true;
    }
}

[Problem(876)]
public sealed class MiddleOfTheLinkedList : ProblemTests<MiddleOfTheLinkedList>
{
    public ListNode? Solve(ListNode? head)
    {
        ListNode? slow = head, fast = head;
        while (fast?.next is not null) { slow = slow!.next; fast = fast.next.next; }
        return slow;
    }
}

[Problem(83)]
public sealed class RemoveDuplicatesFromSortedList : ProblemTests<RemoveDuplicatesFromSortedList>
{
    public ListNode? Solve(ListNode? head)
    {
        ListNode? node = head;
        while (node?.next is not null)
        {
            if (node.next.val == node.val) node.next = node.next.next;
            else node = node.next;
        }
        return head;
    }
}

[Problem(92)]
public sealed class ReverseLinkedListII : ProblemTests<ReverseLinkedListII>
{
    public ListNode? Solve(ListNode? head, int left, int right)
    {
        ListNode dummy = new(0, head);
        ListNode anchor = dummy;
        for (int i = 1; i < left; i++) anchor = anchor.next!;

        ListNode current = anchor.next!;
        for (int i = 0; i < right - left; i++)
        {
            ListNode lifted = current.next!;
            current.next = lifted.next;
            lifted.next = anchor.next;
            anchor.next = lifted;
        }
        return dummy.next;
    }
}

[Problem(695)]
public sealed class MaxAreaOfIsland : ProblemTests<MaxAreaOfIsland>
{
    public int Solve(int[][] grid)
    {
        int best = 0;
        for (int r = 0; r < grid.Length; r++)
            for (int c = 0; c < grid[r].Length; c++)
                best = Math.Max(best, Area(grid, r, c));
        return best;
    }

    private static int Area(int[][] grid, int r, int c)
    {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[r].Length || grid[r][c] != 1) return 0;
        grid[r][c] = 0;
        return 1 + Area(grid, r + 1, c) + Area(grid, r - 1, c)
                 + Area(grid, r, c + 1) + Area(grid, r, c - 1);
    }
}

[Problem(994)]
public sealed class RottingOranges : ProblemTests<RottingOranges>
{
    public int Solve(int[][] grid)
    {
        Queue<(int R, int C)> rotten = new();
        int fresh = 0;

        for (int r = 0; r < grid.Length; r++)
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 2) rotten.Enqueue((r, c));
                else if (grid[r][c] == 1) fresh++;
            }

        if (fresh == 0) return 0;

        int[][] steps = [[1, 0], [-1, 0], [0, 1], [0, -1]];
        int minutes = 0;

        while (rotten.Count > 0 && fresh > 0)
        {
            minutes++;
            for (int i = rotten.Count; i > 0; i--)
            {
                (int r, int c) = rotten.Dequeue();
                foreach (int[] step in steps)
                {
                    int nr = r + step[0], nc = c + step[1];
                    if (nr < 0 || nr >= grid.Length || nc < 0 || nc >= grid[nr].Length) continue;
                    if (grid[nr][nc] != 1) continue;
                    grid[nr][nc] = 2;
                    fresh--;
                    rotten.Enqueue((nr, nc));
                }
            }
        }

        return fresh == 0 ? minutes : -1;
    }
}

[Problem(733)]
public sealed class FloodFill : ProblemTests<FloodFill>
{
    public int[][] Solve(int[][] image, int sr, int sc, int color)
    {
        int original = image[sr][sc];
        if (original != color) Fill(image, sr, sc, original, color);
        return image;
    }

    private static void Fill(int[][] image, int r, int c, int original, int color)
    {
        if (r < 0 || r >= image.Length || c < 0 || c >= image[r].Length) return;
        if (image[r][c] != original) return;
        image[r][c] = color;
        Fill(image, r + 1, c, original, color);
        Fill(image, r - 1, c, original, color);
        Fill(image, r, c + 1, original, color);
        Fill(image, r, c - 1, original, color);
    }
}

[Problem(547)]
public sealed class NumberOfProvinces : ProblemTests<NumberOfProvinces>
{
    public int Solve(int[][] isConnected)
    {
        int n = isConnected.Length;
        bool[] seen = new bool[n];
        int provinces = 0;

        for (int i = 0; i < n; i++)
        {
            if (seen[i]) continue;
            provinces++;
            Visit(isConnected, seen, i);
        }
        return provinces;
    }

    private static void Visit(int[][] graph, bool[] seen, int city)
    {
        seen[city] = true;
        for (int next = 0; next < graph.Length; next++)
            if (graph[city][next] == 1 && !seen[next]) Visit(graph, seen, next);
    }
}

[Problem(56)]
public sealed class MergeIntervals : ProblemTests<MergeIntervals>
{
    public int[][] Solve(int[][] intervals)
    {
        int[][] sorted = [.. intervals.OrderBy(interval => interval[0])];
        List<int[]> merged = [];

        foreach (int[] interval in sorted)
        {
            if (merged.Count > 0 && interval[0] <= merged[^1][1])
                merged[^1][1] = Math.Max(merged[^1][1], interval[1]);
            else
                merged.Add([interval[0], interval[1]]);
        }
        return [.. merged];
    }
}

[Problem(57)]
public sealed class InsertInterval : ProblemTests<InsertInterval>
{
    public int[][] Solve(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = [];
        int start = newInterval[0], end = newInterval[1], i = 0;

        while (i < intervals.Length && intervals[i][1] < start) result.Add(intervals[i++]);

        while (i < intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i++;
        }
        result.Add([start, end]);

        while (i < intervals.Length) result.Add(intervals[i++]);
        return [.. result];
    }
}
