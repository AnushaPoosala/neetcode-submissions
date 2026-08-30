public class MinStack {
     Stack<int> minStk;
     Stack<int> sk;

    public MinStack() 
    {
      minStk=new Stack<int>();  
      sk=new Stack<int>();
    }
    
    public void Push(int val) 
    {
       
        sk.Push(val);
        if(!(minStk.Count==0))
        {
            val=Math.Min(val,minStk.Peek());
        }
        minStk.Push(val);
        //Here we are maintaing MinVal in MinStack
        //ex: If we have 4 ele in sk, We maintain the min of all of the 4 ele in the 4th place of the Minstack
        //val=Math.Min(val,(minStk.Count==0)?val:minStk.Peek());
        //minStk.Push(val);
        
    }
    
    public void Pop() 
    {
        sk.Pop();
        minStk.Pop();
    }
    
    public int Top() 
    {
       return sk.Peek(); 
    }
    
    public int GetMin() 
    {
        // int res=minStk.GetMin();
        int res=minStk.Peek();
         return  res;
    }
}
