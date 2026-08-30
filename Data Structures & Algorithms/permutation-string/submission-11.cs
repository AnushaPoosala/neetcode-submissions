public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        if(s1.Length>s2.Length)
        return false;
        
        int[] a1=new int[26];
        int[] a2=new int[26];
        for(int i=0;i<s1.Length;i++)
        {
            int index=s1[i]-'a';
            a1[index]++;

            int index2=s2[i]-'a';
            a2[index2]++;
        }
        int matches=0;
        for(int i=0;i<26;i++)
        {
            if(a1[i]==a2[i])
            matches++;
        }

        int l=0; int r=s1.Length;
        while(r<s2.Length)
        {
            if(matches==26)
            return true;

            int index=s2[r]-'a';
            a2[index]++;

            if(a1[index]==a2[index])
            matches++;
            else if(a2[index]-1==a1[index])
            matches--;

            int index2=s2[l]-'a';
            a2[index2]--;

            if(a1[index2]==a2[index2])
            matches++;
            else if(a1[index2]==a2[index2]+1)
            matches--;

            l++;
            r++;
        }
        return (matches==26)?true:false;
    }
}
