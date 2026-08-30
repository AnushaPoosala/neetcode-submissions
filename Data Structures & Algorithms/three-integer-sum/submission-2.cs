public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        List<List<int>> output=new List<List<int>>();
        
        int count=0;

        for (int i=0;i<nums.Length-2;i++)
        {
            if (i>0 && nums[i] == nums[i-1])
            continue;
            
            int reqSum=0-nums[i];
            int left=i+1;
            int right=nums.Length-1;

            while(left<right)
            {
                 if (nums[i] > 0) break; //for ex{1,4,5,6,7} we can not achieve a target =0(target sum=0)
                int sum=nums[left]+nums[right];

                if(sum<reqSum)
                left++;

                else if(sum>reqSum)
                right--;

                else if(sum==reqSum)
                {
                    output.Add(new List<int>());
                    output[count].Add(nums[i]);
                    output[count].Add(nums[left]);
                    output[count].Add(nums[right]);
                    count++;left++;right--;
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;}
                }
            }
        }
        return output;
    }
}
