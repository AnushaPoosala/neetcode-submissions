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
        int carry=0;
        ListNode dummy=new ListNode(0,null);
        ListNode output=dummy;

        while(l1!=null || l2!=null || carry!=0)
        {
            int result=carry+(l1!=null?l1.val:0)+(l2!=null?l2.val:0);
            
            dummy.next=new ListNode(result%10);
            dummy=dummy.next;
            carry=result/10;

            l1=(l1!=null)?l1.next:null;
            l2=(l2!=null)?l2.next:null;
        }
        return output.next;
    }
}
