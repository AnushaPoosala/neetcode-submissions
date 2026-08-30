public class MinStack {
Stack<int> sk;
Stack<int> minSk;
    public MinStack() 
    {
        sk=new Stack<int>();
        minSk=new Stack<int>();
    }
    
    public void Push(int val) 
    {
        sk.Push(val);
        if(minSk.Count==0)
        minSk.Push(val);
        else
        {
            int min=(val<minSk.Peek())?val:minSk.Peek();
            minSk.Push(min);
        }
    }
    
    public void Pop() {
       sk.Pop();
       minSk.Pop(); 
    }
    
    public int Top() {
        return sk.Peek();
    }
    
    public int GetMin() {
           return  minSk.Peek(); 
    }
}
