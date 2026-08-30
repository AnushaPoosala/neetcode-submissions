public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output=new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            output[i]=1;
        }
        //pre product
        for(int i=1;i<output.Length;i++)
        {
            output[i]=output[i-1]*nums[i-1];
        } 
        //post product;

        int postfix=1;
        for(int i=output.Length-1;i>=0;i--)
        {
            output[i]=output[i]*postfix;
            postfix=postfix*nums[i];
        }
        return output;
    }
}
