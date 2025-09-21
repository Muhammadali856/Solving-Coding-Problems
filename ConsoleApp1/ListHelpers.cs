using System;
using System.Collections.Generic;

public static class ListHelpers
{
    public static ListNode? Build(int[] values)
    {
        var dummy = new ListNode();
        var tail = dummy;

        foreach (var v in values)
        {
            tail.next = new ListNode(v);
            tail = tail.next;
        }
        return dummy.next;
    }

    public static int[] ToArray(ListNode? head)
    {
        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        return list.ToArray();
    }

    public static void Print(ListNode? head)
    {
        Console.WriteLine(string.Join(" -> ", ToArray(head)) + " -> null");
    }
}