/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> dic= new Dictionary<Node,Node>();
        Node temp=head;

        while(temp!=null)
        {
            dic[temp]=new Node(temp.val);
            temp=temp.next;
        }
        temp=head;
        while(temp!=null)
        {
            Node curr=dic[temp];
            curr.next=temp.next!=null?dic[temp.next]:null;
            curr.random=temp.random!=null?dic[temp.random]:null;

            temp=temp.next;
        }
        return head!=null?dic[head]:null;
    }
}
