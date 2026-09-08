namespace LeetCodeLab.Core;

/// <summary>Singly-linked list node, matching LeetCode's declaration exactly.</summary>
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString() => ListNodes.Format(this);
}

public static class ListNodes
{
    /// <summary>Builds a list from LeetCode's array form, e.g. [1,2,3].</summary>
    public static ListNode? FromArray(IEnumerable<int> values)
    {
        ListNode head = new();
        ListNode tail = head;
        foreach (int v in values)
        {
            tail.next = new ListNode(v);
            tail = tail.next;
        }
        return head.next;
    }

    /// <summary>
    /// Builds a list whose tail links back to index <paramref name="pos"/> (-1 for no cycle).
    /// Used by cycle-detection problems, which LeetCode expresses as a separate `pos` input.
    /// </summary>
    public static ListNode? FromArrayWithCycle(IEnumerable<int> values, int pos)
    {
        int[] arr = values.ToArray();
        ListNode? head = FromArray(arr);
        if (head is null || pos < 0 || pos >= arr.Length) return head;

        ListNode entry = head;
        for (int i = 0; i < pos; i++) entry = entry.next!;

        ListNode tail = head;
        while (tail.next is not null) tail = tail.next;
        tail.next = entry;
        return head;
    }

    /// <summary>Materialises a list to an array. Throws on a cycle rather than hanging.</summary>
    public static int[] ToArray(ListNode? head, int guard = 100_000)
    {
        List<int> result = [];
        ListNode? cur = head;
        while (cur is not null)
        {
            if (result.Count > guard)
                throw new InvalidOperationException(
                    $"List exceeded {guard} nodes - the solution probably created a cycle.");
            result.Add(cur.val);
            cur = cur.next;
        }
        return [.. result];
    }

    public static string Format(ListNode? head)
    {
        List<int> seen = [];
        ListNode? cur = head;
        for (int i = 0; cur is not null && i <= 64; i++, cur = cur.next) seen.Add(cur.val);
        string body = string.Join(",", seen.Take(64));
        return cur is not null ? $"[{body},...]" : $"[{body}]";
    }
}
