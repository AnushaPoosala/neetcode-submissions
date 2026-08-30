public class Solution {
    public int Trap(int[] height) 
    {
        // min (leftmax, rightmax)- hight
        int l =0; int r =height.Length-1;
        int result =0;
        int lmax=height[l]; int rMax= height[r];
// [0,2,0,3,1,0,1,3,2,1]
//result=2+2+3+2

        while(l<r)// l=3 r=2
        {
            if(lmax<rMax)// 3<3
            {
                   l++;
               lmax= Math.Max(lmax,height[l]);//3
               result = result+ lmax- height[l];//2-0
            
                
            }
            else{
                r--;
                     rMax= Math.Max(rMax,height[r] );//3
                result = result+rMax-height[r];//2
            //2
            }
        }
        return result;
        
    }
}
