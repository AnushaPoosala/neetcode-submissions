public class Solution {
    public int Trap(int[] height) 
    {
        int l=0;int r=height.Length-1;
        int lMax=height[0]; int rMax=height[r]; int waterAmount=0;

        while(l<r)
        {
            if(height[l]<height[r])
            {
                l=l+1;
                int curr=height[l];
                lMax=Math.Max(curr,lMax);
                waterAmount=lMax-curr+waterAmount;
            }
            else
            {
                r=r-1;
                int curr=height[r];
                rMax=Math.Max(curr,rMax);
                waterAmount=rMax-curr+waterAmount;
            }
        }
        return waterAmount;
    }
}
