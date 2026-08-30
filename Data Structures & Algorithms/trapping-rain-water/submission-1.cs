public class Solution {
    public int Trap(int[] height) 
    {
        if (height == null || height.Length == 0) {
            return 0;
        }
        int l=0; int r=height.Length-1;
        int leftMax=height[l]; int rightMax=height[r]; int output=0; int current=0;
        
        while(l<r)
        {
            if(leftMax<rightMax)
            {
                l++;
                current=height[l];
                leftMax=Math.Max(leftMax,current);
                output=output+(leftMax-current);
            }
            else
            {
                r--;
                current=height[r];
                rightMax=Math.Max(rightMax,current);
                output=output+(rightMax-current);
            }
        }
        return output;
   }
}
