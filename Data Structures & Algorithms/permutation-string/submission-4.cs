public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        int matches=0; int l=0;

        if(s2.Length<s1.Length)
        return false;
        int[] s1Arr=new int[26];
        int[] s2Arr=new int[26];

        for(int i=0;i<s1.Length;i++)
        {
            int index=s1[i]-'a';
            s1Arr[index]=s1Arr[index]+1;

            index=s2[i]-'a';
            s2Arr[index]=s2Arr[index]+1;
        }

        for(int i=0;i<26;i++)
        {
            if(s1Arr[i]==s2Arr[i])
            matches++;
        }

        for(int r=s1.Length;r<s2.Length;r++)
        {
            if(matches==26)
            return true;

            //adjusting the window size by adding the 1 element from right
            int index=s2[r]-'a';
            s2Arr[index]=s2Arr[index]+1;

            if(s1Arr[index]==s2Arr[index])
            matches++;
            else if(s1Arr[index]+1==s2Arr[index])
            matches--;

            //adjusting the window size by reducing 1 element from left
            index=s2[l]-'a';
            s2Arr[index]--;            
            
            if(s1Arr[index]==s2Arr[index])
            matches++;
            else if(s1Arr[index]-1==s2Arr[index])
            matches--;
            
            l++;
        }
        if(matches==26)
            return true;
        else
            return false;

    }
}
