public class Solution {
    public int FindDuplicate(int[] nums) 
    {
        int slow=0;
        int fast=0;
        /*      0 1 2 3 4
        nums = [3,1,3,4,2]

        0 → 3 → 4 → 2
            ↑-------↓
            intersection point=2
            Duplicate = 3
        */

        //1st loop is to find the intersection point-2
        //fast=slow =2 meets at intersection 2 
        while(true)
        {
            slow=nums[slow];
            fast=nums[nums[fast]];
            if(slow==fast)
            break;
        }

        int slow2=0;
        //2nd loop is for Find entrance of cycle (duplicate)
        //slow=slow=3 is the duplicate
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
