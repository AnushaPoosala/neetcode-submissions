public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        int[] freqArr=new int[26];
        int l=0;int r=0;int length=0;int maxFreq=0;

        while(r<s.Length)
        {
            char curr=s[r];
            int index=curr-'A';
            if(freqArr[index]==0)
            {
                freqArr[index]=1;
            }
            else
            freqArr[index]++;
            maxFreq=Math.Max(maxFreq,freqArr[index]);

            while(r-l+1-maxFreq>k)
            {
                int leftIndex=s[l]-'A';
                freqArr[leftIndex]--;
                l=l+1;;
            }
            Console.WriteLine("l:{0}, r:{1},r-l+1: {2},length: {3}",l,r,r-l+1, length);
            length=Math.Max(length,r-l+1);
            r++;
        }
        return length;
        
    }
}
