public class Node
    {
        public int key;
        public int val;
        public Node prev;
        public Node next;
        public Node(int key, int val)
        {
            this.key=key;
            this.val=val;
            prev=null;
            next=null;
        }
    }
public class LRUCache 
{
    private Dictionary<int,Node> dic;
    private int capacity;
    private Node left;
    private Node right;
    public LRUCache(int capacity) 
    {
        this.capacity=capacity;
        this.dic=new Dictionary<int,Node>();
        this.left=new Node(0,0);
        this.right=new Node(0,0);
        left.next=right;
        right.prev=left;
    }
    public void Insert(Node node)
    {
        Node prevNode=right.prev;
        prevNode.next=node;
        node.prev=prevNode;
        node.next=right;
        right.prev=node;
    }
    public void Remove(Node node)
    {
        Node prevNode=node.prev;
        Node nextNode=node.next;
        prevNode.next=nextNode;
        nextNode.prev=prevNode;
    }
    
    public int Get(int key) 
    {
        if(dic.ContainsKey(key))
        {
          Node node= dic[key];
          Remove(node);
          Insert(node);
          return node.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) 
    {
        if(dic.ContainsKey(key))
        {
            Node node = dic[key];
            node.val = value;   // update value
            Remove(node);
            Insert(node);
        }
        else
        {
            Node node = new Node(key, value);
            dic[key] = node;
            Insert(node);

            if(dic.Count > capacity)
            {   
                Node lru = left.next;
                Remove(lru);
                dic.Remove(lru.key);
            }
        }
    }
}
