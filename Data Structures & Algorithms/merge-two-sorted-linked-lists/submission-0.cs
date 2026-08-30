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
 /*
 list1: 1 → 2 → 4
 list2: 1 → 3 → 4
*/
 
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if(list1==null)
        return list2;
        else if(list2==null)
        return list1;

        if(list1.val<=list2.val)
        {
            //1->next = Merge(2→4, 1→3→4) line 25meaning
            list1.next= MergeTwoLists(list1.next,list2);
            return list1;
        }
        else
        { 
            //1->1->next = Merge(2→4, 3→4) line 36meaning
            //list2.next (1->next) list2 is the head in this else condition
            list2.next=MergeTwoLists(list1,list2.next);
            return list2;
        }
        
    }
}