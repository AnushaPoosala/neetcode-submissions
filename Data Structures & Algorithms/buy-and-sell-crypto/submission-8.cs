public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int profit=0;
        int minBuy=100;
        for(int i=0;i<prices.Length;i++)
        {
            minBuy=Math.Min(minBuy,prices[i]);
           profit=Math.Max(profit,prices[i]-minBuy) ;
        }
        return profit;
    }
}
