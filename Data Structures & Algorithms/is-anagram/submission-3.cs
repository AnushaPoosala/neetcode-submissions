public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!=t.Length)
        {
            return false;
        }
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
         {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]]++;
            }
            else
            {
                dic[s[i]] = 1;
            }

        }
        for (int i = 0; i < t.Length; i++)
        {
            if (!dic.ContainsKey(t[i]))
            {
                return false;
            }
            dic[t[i]]--;
            if (dic[t[i]] == 0)
            {  
                dic.Remove(t[i]);
            }

        }
        if (dic.Count!=0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
