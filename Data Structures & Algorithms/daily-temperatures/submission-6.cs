public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        Stack<int[]> sk=new Stack<int[]>();
        int[] output=new int[temperatures.Length];
        
        for(int i=0;i<temperatures.Length;i++)
        {
            int temperature=temperatures[i];
            while(sk.Count>0 && sk.Peek()[1]<temperature)
            {
                int[] DayTemp=sk.Pop();
                output[DayTemp[0]]=i-DayTemp[0];
            }
            sk.Push(new int[]{i,temperature});
        }
        return output;
    }
}
