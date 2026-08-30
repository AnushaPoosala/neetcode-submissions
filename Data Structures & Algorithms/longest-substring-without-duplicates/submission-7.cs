public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        int  l=0; int r=0; int length=0;

        for(r=0;r<s.Length;r++)
        {
            char current=s[r];

            if(dic.ContainsKey(current))
            {
                //l=dic[current]+1;
                l=Math.Max(dic[current]+1,l);
            }
            dic[current]=r;
            Console.WriteLine("Length:{0}",r-l+1);
            length=Math.Max(length,r-l+1);
        }
        return length;
    }
}
