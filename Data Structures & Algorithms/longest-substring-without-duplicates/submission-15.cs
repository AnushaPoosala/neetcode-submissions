public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        int l=0;int r=0; int maxLength=0;
        while(r<s.Length)
        {
            if(!dic.ContainsKey(s[r]))
            {
                dic[s[r]]=r;
            }
            else
            {
                l=Math.Max(l,dic[s[r]]+1);
                dic[s[r]]=r;
            }
            
            maxLength=Math.Max(maxLength,r-l+1);
            r++;
        }
        return maxLength;
    }
}
