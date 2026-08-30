public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int l=1; int r=piles.Max();;
        int minEatSpeed=piles.Max();;
        

        while(l<=r)
        {
            long totTimeToEat=0;
            int mid=l+((r-l)/2);

            for(int i=0;i<piles.Length;i++)
            {
                totTimeToEat=totTimeToEat+(long)Math.Ceiling((double)piles[i]/mid);
            }

            if(totTimeToEat>h)
            l=mid+1;
            else
            {
                minEatSpeed=Math.Min(minEatSpeed,mid);
                r=mid-1;
            }
        }
        return minEatSpeed;
    }
}
