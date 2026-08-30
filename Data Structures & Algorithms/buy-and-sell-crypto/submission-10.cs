public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int profit=0; int maxProfit=0;int minBuy=prices[0];
        for(int i=0;i<prices.Length;i++)
        {
            minBuy=Math.Min(minBuy,prices[i]);
            profit=prices[i]-minBuy;
            maxProfit=Math.Max(profit,maxProfit);
        }
        return maxProfit;
    }
}
