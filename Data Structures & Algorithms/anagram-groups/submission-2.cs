public class Solution 
{
            public List<List<string>> GroupAnagrams(string[] strs)
        {
            List<List<string>> output =new List<List<string>>();

            List<string> lst = new List<string>();

            for (int i = 0; i < strs.Length; i++)
            {
                lst.Add(strs[i]);
            }
                      
            for (int i = 0; i < lst.Count; i++)
            {
                char[] cStr = lst[i].ToCharArray().OrderByDescending(x => x).ToArray();
                output.Add(new List<string>());
                output[i].Add(lst[i]);

                for (int j = i + 1; j < lst.Count; j++)
                {
                    if(lst[i]=="" && lst[j]=="")
                    {
                        output[i].Add(lst[j]);
                        lst.RemoveAt(j);
                        j--;
                        continue;
                    }
                    char[] cStrNext = lst[j].ToCharArray().OrderByDescending(x => x).ToArray() ;
                    if (cStr.Length != cStrNext.Length)
                    {
                        continue;
                    }
                    for(int k=0;k< cStr.Length;k++)
                    {
                        if (cStr[k] != cStrNext[k])
                            break;
                        if(k==cStr.Length-1)
                        {
                            output[i].Add(lst[j]);
                            lst.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            return output;

        }

}
