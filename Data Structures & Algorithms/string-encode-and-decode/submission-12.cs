public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder sb=new StringBuilder();
        for(int i=0;i<strs.Count;i++)
        {
            string word=strs[i];
            sb.Append(word.Length);
            sb.Append('#');
            sb.Append(word);
        }
       // Console.WriteLine(sb);
        return sb.ToString();      
    }

    public List<string> Decode(string s) 
    {
      List<string> output=new List<string>();
    //5#Hello5#World
      int i=0; int length=0;
      while(i<s.Length)
      {
        int j=i;
        while(j<s.Length && s[j]!='#')
        {
            j++;
        }
        length=int.Parse(s.Substring(i,j-i));
        //string word=s.SubString(j+1,length);
        output.Add(s.Substring(j+1,length));
        i=j+length+1;
      }
      return output;  
   }
}
