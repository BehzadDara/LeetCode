using Shared.Classes;

namespace AddTwoNumbers;

public static class Problem
{
    public static ListNode Solve(ListNode l1, ListNode l2)
    {
        return RecursiveAddTwoNumbers(l1, l2, 0)!;
    }

    private static ListNode? RecursiveAddTwoNumbers(ListNode? l1, ListNode? l2, int carry)
    {
        if (l1 is null && l2 is null)
        {
            return carry == 1 ? new ListNode(1) : null;
        }
        else if (l1 is null)
        {
            return RecursiveAddOneNumber(l2, carry);
        }
        else if (l2 is null)
        {
            return RecursiveAddOneNumber(l1, carry);
        }
        else
        {
            return new ListNode((l1.val + l2.val + carry) % 10, RecursiveAddTwoNumbers(l1.next, l2.next, (l1.val + l2.val + carry) / 10));
        }
    }

    private static ListNode? RecursiveAddOneNumber(ListNode? l, int carry)
    {
        if (l is null)
        {
            return carry == 1 ? new ListNode(1) : null;
        }
        else
        {
            return new ListNode((l.val + carry) % 10, RecursiveAddOneNumber(l.next, (l.val + carry) / 10));
        }
    }
}