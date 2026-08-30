public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 1)
            return (target == nums[0]) ? 0 : -1;

        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (nums[mid] == target)
            {
                return mid; ;

            }

            else if (nums[mid] < target)
            {
                l = mid+1;
            }

            else
            {
                r = mid-1;
            }

        }
        return -1;
    }
}
