public class Solution {
    public int FindDuplicate(int[] nums) 
    {
        int fast=0;
        int slow=0;

        for(int i=0;i<nums.Length;i++)
        {
            fast=nums[nums[fast]];
            slow=nums[slow];
            if(fast==slow)
            break;
        }
        int slow2=0;
        for(int i=0;i<nums.Length;i++)
        {
            slow=nums[slow];
            slow2=nums[slow2];
            if(slow==slow2)
            return slow;
        }
        return -1;
    }
}
