public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] A=(nums1.Length<nums2.Length)?nums1:nums2;
        int[] B=(nums1.Length<nums2.Length)?nums2:nums1;

        int total=nums1.Length+nums2.Length;
        int half=(nums1.Length+nums2.Length+1)/2;
        int l=0; int r=A.Length;
        while(l<=r)
        {
            int Amid=(l+r)/2;
            int Bmid=half-Amid;

            int Aleft=(Amid>0)?A[Amid-1]:int.MinValue;
            int Aright=(Amid<A.Length)?A[Amid]:int.MaxValue;
            int Bleft=(Bmid>0)?B[Bmid-1]:int.MinValue;
            int Bright=(Bmid<B.Length)?B[Bmid]:int.MaxValue;
            Console.WriteLine("Amid{0},Bmid:{1}",Amid,Bmid);
            Console.WriteLine("Aleft:{0},Aright:{1},Bleft:{2},Bright:{3}",Aleft,Aright,Bleft,Bright);

            if((Aleft<=Bright) && (Aright>=Bleft))
            {
                if(total%2!=0)
                return Math.Max(Aleft,Bleft);
                else
                return (double)(Math.Max(Aleft,Bleft)+Math.Min(Aright,Bright))/2;
            }
            if(Aleft>Bright)
            r=Amid-1;
            else
            l=Amid+1;
        }
      return -1;  
    }
}
