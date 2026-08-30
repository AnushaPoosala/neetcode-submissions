public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        int count=0; 
        Dictionary<int,int> dic=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                dic[nums[i]]=1;
            }


        }
        return false;
        
    }
}