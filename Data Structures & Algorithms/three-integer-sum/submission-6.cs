public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
         Array.Sort(nums);
         List<List<int>> output=new List<List<int>>();
         
         for(int i=0;i<nums.Length-2;i++)
         {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i]==nums[i-1])
            continue;
            int curr=nums[i];
            int l=i+1;
            int r=nums.Length-1;
            while(l<r)
            {
                int sum=curr+nums[l]+nums[r];
                if(sum==0)
                {
                    output.Add(new List<int>{curr,nums[l],nums[r]});
                    l++;
                    r--;
                    while(l<r && nums[l]==nums[l-1])
                    l++;
                    
                }
                else if(sum<0)
                l++;

                else
                r--;
            }
         }
        return output;
    }
}
