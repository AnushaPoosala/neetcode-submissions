public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        Dictionary<int,char> dic=new Dictionary<int,char>();
        Queue<char> q=new Queue<char>();
        int count=0;

        for(int i=0;i<s.Length;i++)
        {
            char current=s[i]; 
            //s="pwwkew"
            if(q.Contains(current))
            {
                while(q.Peek()!=current)
                {
                    q.Dequeue();
                }
                q.Dequeue();
            }
             q.Enqueue(current);
                count=Math.Max(count,q.Count);
        }
        return count;
    }
}
