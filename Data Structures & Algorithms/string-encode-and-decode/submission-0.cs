public class Solution 
{
    List<int> wordLength=new List<int>();
    public string Encode(IList<string> strs) 
    {
        StringBuilder sb=new StringBuilder();
        
        for(int i=0;i<strs.Count;i++)
        {
            string word=strs[i];
            wordLength.Add(strs[i].Length);

            sb.Append(strs[i]);
            sb.Append("#");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        List<string> result=new List<string>();
        StringBuilder sb=new StringBuilder(s);
        
        int sum=0;
        for(int i=0;i<wordLength.Count;i++)
        {
            sum=sum+wordLength[i];

        }
        List<string> words=new List<string>();
        for(int i=0;i<wordLength.Count;i++)
        {
            words.Add(sb.ToString(0,wordLength[i]));
            sb.Remove(0,wordLength[i]+1);
        }
        return words;

    }
}
