public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        
        Dictionary<int,int> freqDic=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            if(freqDic.ContainsKey(nums[i]))
            {
                freqDic[nums[i]]++;
            }
            else
            {
                freqDic[nums[i]]=1;
            }
        }
        //O(n) time

        List<int>[] bucket=new List<int>[nums.Length+1];
        for(int i=0;i<bucket.Length;i++)
        {
            bucket[i]=new List<int>();
        }
        //O(n) time


        foreach(var pair in freqDic)
        {
            int frequency=pair.Value;
            int number=pair.Key;
            
            
            bucket[frequency].Add(number);

        }
        //O(m)

        // [][1][2][3,4][][]
        int[] result=new int[k]; int count=k-1;
        for(int i=bucket.Length-1;i>=0 && count>=0;i--)
        {
            List<int> currentList=bucket[i];
            
            for(int j=0;j<currentList.Count;j++)
            {
                result[count--]=currentList[j];
            }
          
        }
        return result;
        //O(n+k)


    }
}
