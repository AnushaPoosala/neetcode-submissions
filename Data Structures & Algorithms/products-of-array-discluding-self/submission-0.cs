public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output=new int[nums.Length];
        Array.Fill(output,1);
        
        //[-1,0,1,2,3]
        for(int i=1;i<nums.Length;i++)
        {
            output[i]=output[i-1]*nums[i-1];
            //output[1]=output[0]*nums[0]=1*-1=-1
            //output[2]=output[1]*nums[1]=-1*0=0
            //output[3]=output[2]*nums[2]=0*1=0
            //output[4]=output[3]*nums[3]=0*2=0
            //output={1,-1,0,0,0} nums=[-1,0,1,2,3]
        }

        int postfix=1;
        for(int i=nums.Length-1;i>=0;i--)
        {
            output[i]=output[i]*postfix;
            postfix=nums[i]*postfix;
            //output[4]=output[4]*1=0*1=0  postfix=nums[4]*1=3*1=3
            //output[3]=output[3]*3=0*3=0  postfix=nums[3]*3=2*3=6
            //output[2]=output[2]*6=0*6=0  postfix=nums[2]*6=1*6=6
            //output[1]=output[1]*6=-1*6=-6  postfix=nums[1]*6=0*6=0
            //output[0]=output[0]*0=-1*0=0  postfix=nums[0]*6=-1*6=-6
            //output={1,0,0,0} nums=[-1,0,1,2,3]
        }
        return output;
    }
}
