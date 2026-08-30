/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) 
    {
        ListNode fast=head.next;
        ListNode slow=head;

        while(fast!=null && fast.next!=null)
        {
            fast=fast.next.next;
            slow=slow.next;
        }
        ListNode second=slow.next;

        ListNode prev=slow.next=null;
        ListNode curr=second;
        while(curr!=null)
        {
            ListNode next=curr.next;

            curr.next=prev;
            prev=curr;
            curr=next;
        }
        second=prev;
        ListNode first=head;

        while(second != null)
        {
            ListNode temp1=first.next;
            ListNode temp2=second.next;

            first.next=second;
            second.next=temp1;

            first=temp1;
            second=temp2;
        }

    }
}
