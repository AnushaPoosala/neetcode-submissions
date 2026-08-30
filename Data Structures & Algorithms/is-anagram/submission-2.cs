public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!=t.Length)
        {
            return false;
        }
        char[] schar=s.ToCharArray().OrderByDescending(x=>x).ToArray();
        char[] tchar=t.ToCharArray().OrderByDescending(x=>x).ToArray();

        for(int i=0;i<schar.Length;i++)
        {
            if(schar[i]!=tchar[i])
            {
                return false;
            }

        }
        return true;
    }
}
