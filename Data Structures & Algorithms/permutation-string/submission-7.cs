public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length) {
            return false;
        }

        int[] arr1=new int[26];
        int[] arr2=new int[26];
        int matches=0;

        for(int i=0;i<s1.Length;i++)
        {
            arr1[s1[i]-'a']++;
            arr2[s2[i]-'a']++;
        }

        for(int i=0;i<26;i++)
        {
            if(arr1[i]==arr2[i])
            matches++;
        }

        int l=0; int r=s1.Length;
        while(r<s2.Length)
        {
            if(matches==26)
            return true;

            int curr=s2[r]-'a';
            arr2[curr]++;
            if(arr2[curr]==arr1[curr])
            matches++;
            else if(arr1[curr]+1==arr2[curr])
            {
                matches--;
            }
            r++;

            int curr2=s2[l]-'a';
            arr2[curr2]--;
            if(arr2[curr2]==arr1[curr2])
            matches++;
            else if(arr1[curr2]-1==arr2[curr2])
            {
                matches--;
            }
            l++;;

        }
       if(matches==26)
            return true;
       else
            return false;
 
    }
}
