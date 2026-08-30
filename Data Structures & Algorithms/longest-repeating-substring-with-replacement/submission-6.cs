public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        int l=0;int r=0;int length=0;int maxFreq=0;

        while(r<s.Length)
        {
            char curr=s[r];
            if(!dic.ContainsKey(curr))
            {
                dic[curr]=1;
            }
            else
            {
                dic[curr]++;
            }
            maxFreq=Math.Max(maxFreq,dic[curr]);

            while((r-l+1-maxFreq)>k)
            {
                dic[s[l]]--;
                l++;
            }
            length=Math.Max(length,r-l+1);
            r++;
        }
        return length;
        
    }
}
