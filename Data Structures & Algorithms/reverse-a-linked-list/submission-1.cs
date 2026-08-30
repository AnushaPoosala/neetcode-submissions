/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) 
        {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if(head==null || head.next==null)
        return head;

       ListNode prev=head;
       ListNode curr=prev.next;
       ListNode next=curr.next;

       while(curr.next!=null)
       {
        curr.next=prev;

        prev=curr;
        curr=next;
        next=curr.next;

       }
       curr.next=prev;
       head.next=null;
       return curr;
    }
}
