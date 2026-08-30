public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length==0)
        {
            return 0;
        }
        HashSet<int> numsHashSet=new HashSet<int>(nums);
        int maxLength=1;
        //{-3,1,-4,2,-5,-6}
        foreach(int num in numsHashSet)
        {
            if(numsHashSet.Contains(num+1))
            {
                int length=1;
                while(numsHashSet.Contains(num+length))
                {
                    length++;

                }
                maxLength=Math.Max(maxLength,length);
            }
        }
        return maxLength;
    }
}
