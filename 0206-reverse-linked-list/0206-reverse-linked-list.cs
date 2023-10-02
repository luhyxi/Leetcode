public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
        { return head; }

        ListNode p = ReverseList(head.next);

        ListNode last = head.next;
        last.next = head; head.next = null;
        return p;
    }
}