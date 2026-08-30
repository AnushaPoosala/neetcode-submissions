public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> set=new HashSet<int>();

        for(int i=0;i<nums.Length;i++)
        {
            set.Add(nums[i]);
        }
        return (set.Count==nums.Length)?false:true;
    }
}