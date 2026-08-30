public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!=t.Length)
        return false;

        int[] arr=new int[26];

        for(int i=0;i<s.Length;i++)
        {
            int idx1=s[i]-'a';
            arr[idx1]++;

            int idx2=t[i]-'a';
            arr[idx2]--;
        }
        for(int i=0;i<26;i++)
        {
            if(arr[i]!=0)
            return false;
        }
        return true;
    }
}
