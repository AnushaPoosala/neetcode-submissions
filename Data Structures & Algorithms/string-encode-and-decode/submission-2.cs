public class Solution 
{
    List<int> wordLengthList=new List<int>();
    public string Encode(IList<string> strs) 
    {
        StringBuilder sb=new StringBuilder();
        
        //strs=["neet","code","love","you"] n is the no. of strings
        for(int i=0;i<strs.Count;i++)
        {
            string word=strs[i];
            wordLengthList.Add(strs[i].Length);

            sb.Append(strs[i]);
            sb.Append("#");
        }
        //Time complexity -O(n)

        return sb.ToString();
        //
    }

    public List<string> Decode(string s) 
    {
        List<string> result=new List<string>();
        StringBuilder sb=new StringBuilder(s);
        
        int sum=0;
        for(int i=0;i<wordLengthList.Count;i++)
        {
            sum=sum+wordLengthList[i];

        }
        List<string> words=new List<string>();
        for(int i=0;i<wordLengthList.Count;i++)
        {
            words.Add(sb.ToString(0,wordLengthList[i]));
            sb.Remove(0,wordLengthList[i]+1);
        }
        return words;

    }
}
