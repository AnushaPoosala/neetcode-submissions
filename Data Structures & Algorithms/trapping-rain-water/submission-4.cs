public class Solution 
{
    public int Trap(int[] height) 
    {
        int l=0; int r=height.Length-1;
        int leftMax=0; int rightMax=0;
        int trappedWater=0;

        while(l<=r)
        {
            if(height[l]<height[r])
            {
                int curr=height[l++];
                leftMax=Math.Max(curr,leftMax);
                trappedWater=trappedWater+leftMax-curr;
            }
            else
            {
                int curr=height[r--];
                rightMax=Math.Max(curr,rightMax);
                trappedWater=trappedWater+rightMax-curr;
            }
        }
        return trappedWater;
    }
}
