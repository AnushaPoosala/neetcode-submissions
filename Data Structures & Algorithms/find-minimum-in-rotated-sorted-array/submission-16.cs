public class Solution {
    public int FindMin(int[] nums) 
    {
        if (nums.Length == 1)
            return nums[0];

        int l = 0;
        int r = nums.Length - 1;
        int min=1000;

        while (l <= r)
        {
            int mid = l+((r-l)/2);
            min=Math.Min(min,nums[mid]);

            if(nums[l]<nums[r] && nums[mid]<=min)
            return nums[l];
            else if(nums[l]<=nums[mid])
            l=mid+1;
            else
            r=mid-1;
        }
        return min;
    }
}
