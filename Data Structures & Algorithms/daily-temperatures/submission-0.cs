public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        Stack<int[]> sk=new Stack<int[]>();
        int[] res=new int[temperatures.Length];
        for(int i=0;i<temperatures.Length;i++)
        {
            int t=temperatures[i];
            while(sk.Count>0 && t>sk.Peek()[0])
            {
                int[] pair=sk.Pop();
                res[pair[1]]=i-pair[1];
            }
            int[] pair2=new int[] {t,i};
            sk.Push(pair2);
            Console.WriteLine("i: {0}, Stack temp,Index{1}", i,sk.Peek());
        }
        return res;
    }
}
