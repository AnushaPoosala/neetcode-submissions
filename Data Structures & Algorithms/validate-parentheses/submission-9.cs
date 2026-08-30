public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary<char,char> dic=new Dictionary<char,char>();
        dic['}']='{';
        dic[']']='[';
        dic[')']='(';
        Stack<char> sk=new Stack<char>();

        for(int i=0;i<s.Length;i++)
        {
            if(!dic.ContainsKey(s[i]))
            sk.Push(s[i]);
            else
            {
                if(sk.Count!=0 && sk.Peek()==dic[s[i]])
                {
                    sk.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        return (sk.Count==0)?true:false;
    }
}
