 public class Solution
 {
     public int[] TopKFrequent(int[] nums, int k)
     {
         //{ 1, 2, 2, 3, 3, 3,4,4,5,5 };
         Dictionary<int, int> dic = new Dictionary<int, int>();

         for (int i = 0; i < nums.Length; i++)
         {
             if (dic.ContainsKey(nums[i]))
                 dic[nums[i]]++;
             else
                 dic[nums[i]] = 1;
         }

         List<int> list = new List<int>();
         List<int> lst = new List<int>(10);
         int[] arr = new int[] { };
         int[] arr2 = new int[5];

         List<int>[] arr3 = new List<int>[nums.Length + 1];


         /*   //dic 
         Key(number)  Value(frequency)
         1            1
         2            2
         3            3
         4            2
         5            2
         */
         //bucket={[], [1], [2,4,5] ,[3], [] ,[] ,[]}  Array of lists===each element is a list ==={2,4,5} is a list  , bucketArr is array
         List<int>[] bucketArr = new List<int>[nums.Length + 1];

         for (int i = 0; i < bucketArr.Length; i++)
         {
             bucketArr[i] = new List<int>();
         }

         foreach (var pair in dic)
         {
             int frequency = pair.Value;
             int number = pair.Key;

             bucketArr[frequency].Add(number);
         }
         int count = 0; int[] result = new int[k];
         for (int i=bucketArr.Length-1;i>=0 && count<k; i--)
         {
             if(bucketArr[i].Count!=0)
             {
                 List<int> currentList = bucketArr[i];
                 for(int j=0;j< currentList.Count && count<k;j++)
                 {
                     result[count++] = currentList[j];
                 }
             }
            
         }
         return result;

     }
 }     
