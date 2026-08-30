public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> set= new HashSet<int>(nums);
        int maxLength=0;

        foreach(var num in set)
        {
            int curr=num;
            int length=1;
            if(!set.Contains(num+1))
            {
                while(set.Contains(curr-1))
                {
                    curr=curr-1;
                    length++;
                }
                maxLength=Math.Max(length,maxLength);
            }

        }
        return maxLength;
    }
}
