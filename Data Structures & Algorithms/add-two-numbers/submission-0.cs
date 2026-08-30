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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        int carry=0; ListNode curr1=l1; ListNode curr2=l2;
        ListNode output=new ListNode(0);
        ListNode node=output;
        int sum=0;
int val1=0; int val2=0;
        while(curr1!=null || curr2!=null || carry!=0)
        {
            val1=(curr1==null)?0:curr1.val;
            val2=(curr2==null)?0:curr2.val;

            sum=val1+val2+carry;
            carry=sum/10;
            node.next=new ListNode(sum%10);

            node=node.next;
            curr1=(curr1!=null)?curr1.next:curr1;
            curr2=(curr2!=null)?curr2.next:curr2;
        }
        return output.next;
    }
}
