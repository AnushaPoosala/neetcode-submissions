public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> output=new List<List<string>>();
        Dictionary<string, List<string>> dic=new Dictionary<string, List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            int[] word=new int[26];
            //char[] wordC=str[i].ToCharArray();
            foreach(var letter in strs[i])
            {
                word[letter-'a']++;
            }
            
            string wordArr = string.Join(",", word);

            if(!dic.ContainsKey(wordArr))
            {
                dic[wordArr]=new List<string>();
            }
            dic[wordArr].Add(strs[i]);
        }
        foreach(var kvp in dic)
        {
            output.Add(kvp.Value);
        }
        return output;
    }
}
