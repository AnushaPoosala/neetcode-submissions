public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!=t.Length)
           return false;
        else
        {
            int[] sString=new int[26];
        int[] tString=new int[26];

        for(int i=0;i<s.Length;i++)
        {
            int sCharNumber=s[i]-'a';
            sString[sCharNumber]++;

            int tCharNumber=t[i]-'a';
            tString[tCharNumber]++;
            tString[sCharNumber]--;
        }
        for(int i=0;i<tString.Length;i++)
        {
            if(tString[i]!=0)
             return false;
        }

        return true;
        }
        
    }
}
