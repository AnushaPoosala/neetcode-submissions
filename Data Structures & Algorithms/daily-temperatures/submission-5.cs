public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int[] res=new int[temperatures.Length];
        Stack<int[]> sk=new Stack<int[]>();

        for(int i=0;i<temperatures.Length;i++)
        {
            int currTemp=temperatures[i];
            
            while(sk.Count>0 && sk.Peek()[0]<currTemp)
            {
                int[] prevTemp=sk.Pop();
                res[prevTemp[1]]=i-prevTemp[1];
                

            }
            sk.Push(new int[]{currTemp,i});
        }
        return res;
    }
}
