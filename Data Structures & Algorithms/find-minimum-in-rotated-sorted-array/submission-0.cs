public class Solution {
    public int FindMin(int[] nums) 
    {
        int min=1001;
        foreach(var ele in nums)
        {
            min=Math.Min(min,ele);
        }
       return min; 
    }
}
