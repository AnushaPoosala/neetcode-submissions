public class Solution 
{
    List<int> wordLengthList=new List<int>();
    public string Encode(IList<string> strs) 
    {
         if (strs.Count == 0) return "";
        StringBuilder sb=new StringBuilder();
        //O(1) for StringBuilder
        
        //strs=["neet","code","love","you"] n is the no. of strings
        //m is the sum of lengths of all the strings
        for(int i=0;i<strs.Count;i++)
        {
            string word=strs[i];
            wordLengthList.Add(strs[i].Length);

            sb.Append(strs[i]);
            sb.Append("#");
        }
        //Time complexity -O(n)  --inside for O(n) for list ---O(m) for sb append---# append O(n)
        return sb.ToString(); //O(m+n)time space
        //
    }

    public List<string> Decode(string s)
    {
        
       StringBuilder sb = new StringBuilder(s); //time=space= O(m + n)
       //sb={neet#code#love#you#}
    
       List<string> words = new List<string>();  int count = 0;
       //sb={neet#code# l  o  v  e  #  y  o  u  #}      wordLengthlist={4,4,4,3}
       //    0123456789 10 11 12 13 14 15 16 17 18             //count=0+4+2=6      count=12=6+4+2--i=2  count=18=12+4+2--i=3
       for (int i = 0; i < wordLengthList.Count; i++)
       {
          words.Add(sb.ToString(count-i, wordLengthList[i])) ; //time for sb.ToString(count-i, wordLengthList[i]:O(m)
          //words.Add=timeO(n)
          count = count + wordLengthList[i]+2;//O(1) per iteration total time is O(n)
          //sb.Remove(0, wordLengthList[i] + 1);
       }
       return words;
    }
}
