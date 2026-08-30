public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<List<string>> output=new List<List<string>>();
        Dictionary<String, List<String>> dic = new Dictionary<String, List<String>>();
        for(int i=0;i<strs.Length;i++)
        {
            char[] charArray = strs[i].ToCharArray().OrderDescending().ToArray();
            string sortedS = new string(charArray);
            if(!dic.ContainsKey(sortedS))
            {
                dic[sortedS] = new List<string>();
            }
            dic[sortedS].Add(strs[i]);

        }

        foreach(var kvp in dic)
        {
            output.Add(kvp.Value);

        }
        return output;
        
    }
}
