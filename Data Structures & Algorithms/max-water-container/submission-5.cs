public class Solution {
    public int MaxArea(int[] heights) 
    {
        if(heights.Length==2)
            return (heights[0]<heights[1])?heights[0]:heights[1];
        
        int left=0; int right=heights.Length-1;
        int contArea=0; int maxArea=0; 

        while(left<right)
        {
            contArea=(Math.Min(heights[left],heights[right]))*(right-left);
            maxArea=Math.Max(maxArea,contArea);

            if(heights[left]<heights[right])
            left++;
            else
            right--;

        }
        return maxArea;   
    }
}
