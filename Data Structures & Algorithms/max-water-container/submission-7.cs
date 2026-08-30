public class Solution {
    public int MaxArea(int[] heights) 
    {
        // [1,7,2,5,4,7,3,6]
        int l=0; 
        int r=heights.Length-1;
        int ContArea=0; int maxArea=0;

        while(l<r)
        {
            ContArea=(Math.Min(heights[l],heights[r])*(r-l));
            maxArea=Math.Max(maxArea,ContArea);

            if(heights[l]<heights[r])
            l++;
            else
            r--;


        }
        return maxArea;
        
    }
}
