public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // 1. Count frequency
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }

        // 2. Bucket sort: Create buckets where index = frequency
        // Max frequency possible = nums.Length
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in freq)
        {
            int count = pair.Value;
            int number = pair.Key;

            if (buckets[count] == null)
                buckets[count] = new List<int>();

            buckets[count].Add(number);
        }

        // 3. Collect top K frequent elements from buckets
        List<int> result = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return result.Take(k).ToArray();
    }
}
