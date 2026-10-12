public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> diffDic=new Dictionary<int,int>();
        //int[] result=new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            int diff=target-nums[i];
            if(diffDic.ContainsKey(diff))
            {
                return new int[]{diffDic[diff],i};
                
                
            }
            else
            {
                diffDic[nums[i]]=i;
            }
        }
        return new int[2];
    }
}
