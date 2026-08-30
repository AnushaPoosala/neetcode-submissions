public class Solution 
{
    public int Trap(int[] height) 
    {
        int l=0; int r=height.Length-1;
        int leftMax=height[l]; int rightMax=height[r];
        int trappedWater=0;

        while(l<r)
        {
            if(leftMax<rightMax)
            {
                l++;
                int curr=height[l];
                leftMax=Math.Max(curr,leftMax);
                trappedWater=trappedWater+leftMax-curr;
            }
            else
            {
                r--;
                int curr=height[r];
                rightMax=Math.Max(curr,rightMax);
                trappedWater=trappedWater+rightMax-curr;
            }
        }
        return trappedWater;
    }
}
