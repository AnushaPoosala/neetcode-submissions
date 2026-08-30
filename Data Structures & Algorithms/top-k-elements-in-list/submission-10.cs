public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        int[] result=new int[k];
        for(int i=0;i<nums.Length;i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]=1;
            }
            dic[nums[i]]++;
        }
        //return dic.Where(x=>x.Value>k).Select(x=>x.Key).ToArray();
       dic = dic.OrderByDescending(x => x.Value).ToDictionary(dic => dic.Key, dic => dic.Value);
       int count=0;
        for(int i=0;i<dic.Count && count < k; i++)
        {
            result[i] = dic.ElementAt(i).Key;
            count++;
        }
        return result;
        
    }

}
