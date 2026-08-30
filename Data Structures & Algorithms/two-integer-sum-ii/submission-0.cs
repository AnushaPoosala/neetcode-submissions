public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int[] output=new int[2];
        int min=0; int max=numbers.Length-1;
        //{1,2,3,4} target =3

        while(min<max)
        {
            while(min<max && (numbers[min]+numbers[max])<target)
            min++;

            while(min<max && (numbers[min]+numbers[max])>target)
            max--;

            if((numbers[min]+numbers[max])==target)
            {
                output[0]=min+1;
                output[1]=max+1;
                break;
            }

        }
        return output;
    }
}
