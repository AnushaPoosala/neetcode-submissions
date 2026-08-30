public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> sk=new Stack<int>();
        //tokens=["2","1","+","3","*"]
        for(int i=0;i<tokens.Length;i++)
        {
            string curr=tokens[i];
            if(curr=="+")
            {
                sk.Push(sk.Pop() + sk.Pop());
            }
            else if(curr=="-")
            {
                int a=sk.Pop();
                int b=sk.Pop();
                sk.Push(b - a);
            }
            else if(curr=="*")
            {
                sk.Push(sk.Pop() * sk.Pop());
            }
            else if(curr=="/")
            {
                int a=sk.Pop();
                int b=sk.Pop();
                sk.Push(b/a);
            }
            else
            sk.Push(int.Parse(curr));

            
        }
        return sk.Peek();
    }
}
