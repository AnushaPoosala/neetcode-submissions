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
    public Node copyRandomList(Node head) 
    {
        Dictionary<Node,Node> copyDic=new Dictionary<Node,Node>();
        //Original Key, Copy Value
        //we will make a copy of head in the value of dic

        Node curr=head;
        while(curr!=null)
        {
            Node copyNode=new Node(curr.val);
            copyDic[curr]=copyNode;
            curr=curr.next;
        }

        curr=head;
        while(curr!=null)
        {
            Node fillValueOfCopyDic=copyDic[curr];
            fillValueOfCopyDic.next=(curr.next!=null)?copyDic[curr.next]:null;
            fillValueOfCopyDic.random=(curr.random!=null)?copyDic[curr.random]:null;
            curr=curr.next;
        }

        return (head==null)?null:copyDic[head];
    }
}
