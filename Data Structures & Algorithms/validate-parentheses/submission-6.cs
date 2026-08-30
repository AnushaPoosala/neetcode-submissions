public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary<char,char> dic=new Dictionary<char,char>();
        dic[')']='(';
        dic[']']='[';
        dic['}']='{';
        Stack<char> sk=new Stack<char>();
        
        for(int i=0;i<s.Length;i++)
        {
            Console.WriteLine(s[i]);
            char curr=s[i];
            if(dic.ContainsKey(curr))
            {
                if(sk.Count>0 && (dic[curr]==sk.Peek()))
                    sk.Pop();
                else
                    return false;
            }
            else
            {
                sk.Push(curr);
            }

        }
        return sk.Count==0;
    }
}
