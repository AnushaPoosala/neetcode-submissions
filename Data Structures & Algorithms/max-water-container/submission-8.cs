public class Solution {
    public int MaxArea(int[] heights) 
    {
        if(heights.Length==2)
            return (heights[0]<heights[1])?heights[0]:heights[1];
        int maxWater=0; int Area=0;
        int l=0; int r= heights.Length-1;

        while(l<=r)
        {
            Area=Math.Min(heights[l],heights[r])*(r-l);
            maxWater=Math.Max(maxWater,Area);

            if(heights[l]<heights[r])
            l++;
            else 
            r--;
        }
        return maxWater;

    }
}
