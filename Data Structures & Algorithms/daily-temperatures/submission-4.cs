public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        if(n == 1) return res;
        
        Stack<int[]> stack = new Stack<int[]>();

        for(int i =0; i<n; i++ )
        {
            int t = temperatures[i];

            while(stack.Count>0&& t>stack.Peek()[0])
            {
                int[] prevtemp = stack.Pop();
                res[prevtemp[1]]= i-prevtemp[1];
            }
            stack.Push(new int[]{t, i});

        }
        return res;
        
    }
}
