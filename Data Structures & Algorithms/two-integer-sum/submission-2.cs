public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> diffDic=new Dictionary<int,int>();
        int[] result=new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            int diff=target-nums[i];
            if(diffDic.ContainsKey(diff))
            {
                result[0]=diffDic[diff];
                result[1]=i;
                break;
                
            }
            else
            {
                diffDic[nums[i]]=i;
            }
        }
        return result;
    }
}
