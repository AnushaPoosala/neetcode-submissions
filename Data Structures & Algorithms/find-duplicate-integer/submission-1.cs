public class Solution {
    public int FindDuplicate(int[] nums) 
    {
        int slow=0;
        int fast=0;

        //1st loop is to find the intersection point
        while(true)
        {
            slow=nums[slow];
            fast=nums[nums[fast]];
            if(slow==fast)
            break;
        }

        int slow2=0;
        //2nd loop is for Find entrance of cycle (duplicate)
        while(true)
        {
            slow2=nums[slow2];
            slow=nums[slow];
            while(slow==slow2)
            return slow;
        }
        return -1;
    }
}
