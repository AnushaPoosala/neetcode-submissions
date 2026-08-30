public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        int l=0;int r=0;int length=0;

        while(r<s.Length)
        {
            char curr=s[r];
            if(!dic.ContainsKey(curr))
            {
                dic[curr]=r;
            }
            else
            {
                //l=Math.Max(dic[curr]+1,r);
                l=Math.Max(dic[curr]+1,l);
                dic[curr]=r;

            }
            length=Math.Max(length,r-l+1);
            r++;
        }
        return length;
    }
}
