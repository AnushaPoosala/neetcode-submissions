public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        int leftOverSum;
        int[] output=new int[]{};
        for(int i=0;i<nums.Length;i++)
        {
            leftOverSum=target-nums[i];
            if(dic.ContainsKey(leftOverSum))
            {
                return new[] {dic[leftOverSum],i};
            }
            else
            {
                dic[nums[i]]=i;
            }

        }
        return output;


    }
}
