public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> freqDic=new Dictionary<char,int>();
        int l=0;int r=0;int length=0;int maxFreq=0;

        while(r<s.Length)
        {
            char curr=s[r];
            if(!freqDic.ContainsKey(curr))
            {
                freqDic[curr]=1;
            }
            else
            freqDic[curr]++;
            maxFreq=Math.Max(maxFreq,freqDic[curr]);

            while(r-l+1-maxFreq>k)
            {
                freqDic[s[l]]--;
                l=l+1;;
            }
            Console.WriteLine("l:{0}, r:{1},r-l+1: {2},length: {3}",l,r,r-l+1, length);
            length=Math.Max(length,r-l+1);
            r++;
        }
        return length;
        
    }
}
