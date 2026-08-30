public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> output=new List<List<string>>();
        Dictionary<string,List<string>> dic=new Dictionary<string,List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            string word=strs[i];
            int[] wordArr=new int[26];

            for(int j=0;j<word.Length;j++)
            {
                int idx=word[j]-'a';
                wordArr[idx]++;
            }
            string wordArrKey=string.Join(",",wordArr);
            if(!dic.ContainsKey(wordArrKey))
            {
                dic[wordArrKey]=new List<string>();
            }
            dic[wordArrKey].Add(word);
        }
       
        foreach(var kvp in dic)
        {
           List<string> values=kvp.Value; 
           output.Add(values);
        }
        return output;
    }
}
