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
            Console.WriteLine("left: {0}, right {1}, mid: {2}", l, r, mid);

            if (l == r && nums[mid] != target)
            {
                Console.WriteLine("l==r left: {0}, right {1}, nums[mid]: {2}", l, r, nums[mid]);
                return -1;
            }

            if (nums[mid] == target)
            {
                Console.WriteLine("nums[mid]==target left: {0}, right {1}, nums[mid]: {2}", l, r, nums[mid]);
                return mid; ;

            }

            else if (nums[mid] < target)
            {
                l = mid+1;
                Console.WriteLine("nums[mid]<target left: {0}, right {1}, nums[mid]: {2}", l, r, nums[mid]);
            }

            else
            {
                r = mid;
                Console.WriteLine("nums[mid]>target left: {0}, right {1}, nums[mid]: {2}", l, r, nums[mid]);
            }

        }
        return -1;
    }
}
