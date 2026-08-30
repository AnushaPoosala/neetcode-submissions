public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length) {
            return false;
        }
        int[] a1=new int[26];
        int[] b1=new int[26];
        int matches=0;
        int l=0; 
        int r=s1.Length;

        for(int i=0;i<s1.Length;i++)
        {
            a1[s1[i]-'a']++;
            b1[s2[i]-'a']++;
        }
        for(int i=0;i<26;i++)
        {
            if(a1[i]==b1[i])
            matches++;
        }
        while(r<s2.Length)
        {
            if(matches==26)
            return true;

            int curr=s2[r]-'a';
            b1[curr]++;
            if(a1[curr]==b1[curr])
            matches++;
            else if(b1[curr]-1==a1[curr])
            matches--;

            int curr2=s2[l]-'a';
            l++;
            b1[curr2]--;
            if(a1[curr2]==b1[curr2])
            matches++;
            else if(b1[curr2]+1==a1[curr2])
            matches--;

            r++;
        }
        return (matches==26)?true:false;
    }
}
