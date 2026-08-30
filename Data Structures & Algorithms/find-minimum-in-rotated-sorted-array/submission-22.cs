public class Solution {
    public int FindMin(int[] nums) 
    {
        int l = 0;
        int r = nums.Length - 1;int min=nums[0];

        while (l <= r)
        {
            int mid = l+((r-l)/2);
            min=Math.Min(nums[mid],min);

            if(nums[l]<nums[r] && nums[l]<min)
            {
                return nums[l];
            }

            else if(nums[l]<=nums[mid])
            l=mid+1;

            else
            r=mid-1;
        }
        return min;
    }
}
