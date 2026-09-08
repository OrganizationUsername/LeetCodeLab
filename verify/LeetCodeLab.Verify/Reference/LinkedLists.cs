namespace LeetCodeLab.Verify.Reference;

[Problem(19)]
public sealed class RemoveNthNodeFromEndOfList : ProblemTests<RemoveNthNodeFromEndOfList>
{
    public ListNode? Solve(ListNode? head, int n)
    {
        ListNode dummy = new(0, head);
        ListNode? lead = dummy, trail = dummy;
        for (int i = 0; i <= n; i++) lead = lead!.next;
        while (lead is not null) { lead = lead.next; trail = trail!.next; }
        trail!.next = trail.next!.next;
        return dummy.next;
    }
}

[Problem(21)]
public sealed class MergeTwoSortedLists : ProblemTests<MergeTwoSortedLists>
{
    public ListNode? Solve(ListNode? list1, ListNode? list2)
    {
        ListNode dummy = new();
        ListNode tail = dummy;
        while (list1 is not null && list2 is not null)
        {
            if (list1.val <= list2.val) { tail.next = list1; list1 = list1.next; }
            else { tail.next = list2; list2 = list2.next; }
            tail = tail.next;
        }
        tail.next = list1 ?? list2;
        return dummy.next;
    }
}

[Problem(23)]
public sealed class MergeKSortedLists : ProblemTests<MergeKSortedLists>
{
    public ListNode? Solve(ListNode?[] lists)
    {
        ListNode? merged = null;
        foreach (ListNode? list in lists) merged = Merge(merged, list);
        return merged;
    }

    private static ListNode? Merge(ListNode? a, ListNode? b)
    {
        ListNode dummy = new();
        ListNode tail = dummy;
        while (a is not null && b is not null)
        {
            if (a.val <= b.val) { tail.next = a; a = a.next; }
            else { tail.next = b; b = b.next; }
            tail = tail.next;
        }
        tail.next = a ?? b;
        return dummy.next;
    }
}

[Problem(141)]
public sealed class LinkedListCycle : ProblemTests<LinkedListCycle>
{
    public bool Solve(ListNode? head)
    {
        ListNode? slow = head, fast = head;
        while (fast?.next is not null)
        {
            slow = slow!.next;
            fast = fast.next.next;
            if (ReferenceEquals(slow, fast)) return true;
        }
        return false;
    }
}

[Problem(143)]
public sealed class ReorderList : ProblemTests<ReorderList>
{
    public void Solve(ListNode? head)
    {
        if (head?.next is null) return;

        // Split at the midpoint, reverse the tail, then interleave.
        ListNode slow = head, fast = head;
        while (fast.next?.next is not null) { slow = slow.next!; fast = fast.next.next; }

        ListNode? second = slow.next;
        slow.next = null;

        ListNode? previous = null;
        while (second is not null)
        {
            ListNode? next = second.next;
            second.next = previous;
            previous = second;
            second = next;
        }

        ListNode? first = head;
        while (previous is not null)
        {
            ListNode? firstNext = first!.next;
            ListNode? secondNext = previous.next;
            first.next = previous;
            previous.next = firstNext;
            first = firstNext;
            previous = secondNext;
        }
    }
}

[Problem(206)]
public sealed class ReverseLinkedList : ProblemTests<ReverseLinkedList>
{
    public ListNode? Solve(ListNode? head)
    {
        ListNode? previous = null;
        while (head is not null)
        {
            ListNode? next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }
        return previous;
    }
}
