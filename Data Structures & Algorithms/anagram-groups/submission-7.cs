public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        
        List<List<string>>  output=new List<List<string>> ();
        Dictionary<string,List<string>> dic=new Dictionary<string,List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            string word=strs[i];
            int[] wordArr=new int[26];
            for(int j=0;j<word.Length;j++)
            {
                int currIndex=word[j]-'a';
                wordArr[currIndex]++;
            }
            string key=String.Join(",",wordArr);
            if(!dic.ContainsKey(key))
            {
                dic[key]=new List<string>();
            }
          
            dic[key].Add(word);

            

        }
        foreach(var kvp in dic)
            {
                output.Add(kvp.Value);
            }
        return output;
    }
}
