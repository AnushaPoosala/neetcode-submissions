public class Node
{
    public int key;
    public int value;
    public Node prev;
    public Node next;
    public Node(int key,int value)
    {
        this.key=key;
        this.value=value;
        prev=null;
        next=null;
    }
}
public class LRUCache 
{
    private int _capacity;
    private Dictionary<int,Node> _capDic;
    private Node left;
    private Node right;

    public LRUCache(int capacity) 
    {
       _capacity=capacity; 
       _capDic=new Dictionary<int,Node>();
       left=new Node(0,0);
       right=new Node(0,0);
       left.next=right;
       right.prev=left;
    }

    //Inserting the node just befor rightdummyNode
    public void Insert(Node node)
    {
        Node prevNode=right.prev;
        prevNode.next=node;
        node.prev=prevNode;
        node.next=right;
        right.prev=node;
    }

    //Removing the Node by pointing the Prev---><---Next
    public void Remove(Node removeNode)
    {
        Node prevNode=removeNode.prev;
        Node nextNode=removeNode.next;
        prevNode.next=nextNode;
        nextNode.prev=prevNode;
    }
    
    public int Get(int key) 
    {
       if(_capDic.ContainsKey(key))
       {
            Node node=_capDic[key];
            Remove(node);
            Insert(node); 
            return node.value;
       }
       return -1;
        
    }
    
    public void Put(int key, int value) 
    {
        if(_capDic.ContainsKey(key))
        {
            Node node=_capDic[key];
            Remove(node);  
        }
        Node newNode=new Node(key,value);
        _capDic[key]=newNode;
        Insert(newNode);
        if(_capDic.Count>_capacity)
        {
            Node removeNode=left.next;
            Remove(removeNode);
            _capDic.Remove(removeNode.key);
        }
        
        
    }
}
