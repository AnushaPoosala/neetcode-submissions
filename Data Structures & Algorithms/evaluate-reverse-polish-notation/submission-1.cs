public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> sk=new Stack<int>();

        for(int i=0;i<tokens.Length;i++)
        {
            if(tokens[i]=="+")
            sk.Push(sk.Pop()+sk.Pop());
            else if(tokens[i]=="-")
            {
                int b=sk.Pop();
                int a=sk.Pop();
                sk.Push(a-b);
            }
            else if(tokens[i]=="*")
            sk.Push(sk.Pop()*sk.Pop());
            else if(tokens[i]=="/")
            {
                int b=sk.Pop();
                int a=sk.Pop();
                sk.Push(a/b);
            }
            else
            sk.Push(int.Parse(tokens[i]));
        }
        return sk.Pop();
    }
}
