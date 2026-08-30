public class Solution
{
    public string Encode(IList<string> strs)
    {
        StringBuilder encodedString = new StringBuilder();
        foreach (string word in strs)
        {
            encodedString.Append(word.Length).Append("#").Append(word);
        }

        /*Time: for loop:O(n)
        encodedString.Append(word)-O(k) for each iteration--all itearationsO(m)
        encodedString.Append(word.Length)--O(n) for all iterations
        encodedString.Append("#")--O(n) for all iterations
        final Time=O(m) + O(n) + O(n) = O(m + n)
        */
        return encodedString.ToString();
        /*time for encodedString.ToString()===O(m+n)==Space is also same
        Copies all characters into a new string
        total chars in encodedString=m+n(n no. of #)
        */
    }

    public List<string> Decode(string s)
    {
        List<string> output = new List<string>();
        int wordLength = 0;
        //  4#neet 4 # c o  d  e  4  #  l  o  v  e  3  #  you
        //  012345 6 7 8 9  10 11 12 13 14 15 16 17 18 19 20
        //  4#neet 1 1 # co  d  e   l  o  v  e  y o  u
        int i=0;
        while(i<s.Length)
        {
            int j = i;
            while (s[j]!='#')
            {
                j++;
            }
            wordLength = int.Parse(s.Substring(i, j - i));
            output.Add(s.Substring(j + 1, wordLength));
            i = j+1 + wordLength;

        }
        return output;
    }
}