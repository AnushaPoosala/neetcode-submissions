public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int minBuy=prices[0];
        int profit=0;
        for(int i=0;i<prices.Length;i++)
        {   
            profit=Math.Max(profit,prices[i]-minBuy);
            minBuy=Math.Min(minBuy,prices[i]);
        }
                
        return profit;
        
    }
}
