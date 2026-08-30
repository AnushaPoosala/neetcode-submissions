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
        ListNode slow=head;
        ListNode fast=head.next;

        while(fast!=null && fast.next!=null)
        {
            fast=fast.next.next;
            slow=slow.next;
        }
        ListNode second=slow.next;
        slow.next=null;

        ListNode pre=null;
        ListNode curr=second;
        while(curr!=null)
        {
            ListNode next=curr.next;

            curr.next=pre;

            pre=curr;
            curr=next;
        }
        second=pre;
        ListNode first=head;

        while(second!=null)
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
