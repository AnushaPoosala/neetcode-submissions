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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode dummy=new ListNode(0,null);
        ListNode output=dummy;
        ListNode temp1=list1;
        ListNode temp2=list2;

        while(temp1!=null && temp2!=null)
        {
            if(temp1.val<temp2.val)
            {
                dummy.next=temp1;
                temp1=temp1.next;
            }
            else
            {
                dummy.next=temp2;
                temp2=temp2.next;
            }
            dummy=dummy.next;
        }
        dummy.next=(temp1==null)?temp2:temp1;
        return output.next;
    }
}