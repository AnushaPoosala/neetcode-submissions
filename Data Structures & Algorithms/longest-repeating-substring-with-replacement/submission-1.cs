public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        int l=0; int r=0; int maxFreq=0; int maxLength=0;
        
        for(r=0;r<s.Length;r++)
        {
            char curr=s[r];
            if(!dic.ContainsKey(curr))
                dic[curr]=1;
            else
                dic[curr]++;
            maxFreq=Math.Max(maxFreq,dic[curr]);

            while(((r-l+1)-maxFreq)>k)
            {
                dic[s[l]]--;
                l++;
            }
            maxLength=Math.Max(r-l+1,maxLength);
        }
        return maxLength;

    }
}
