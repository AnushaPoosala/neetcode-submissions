public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] A=(nums1.Length<=nums2.Length)?nums1:nums2;
        int[] B=(nums1.Length>nums2.Length)?nums1:nums2;
        int total=A.Length+B.Length;
        int half=(total+1)/2;
        int l=0; 
        int r=A.Length;
        while(l<=r)
        {
            int AMid=(l+r)/2;
            int BMid=half-AMid;
            int ALeft=(AMid>0)?A[AMid-1]:int.MinValue;
            int ARight=(AMid<A.Length)?A[AMid]:int.MaxValue;
            int BLeft=(BMid>0)?B[BMid-1]:int.MinValue;
            int BRight=(BMid<B.Length)?B[BMid]:int.MaxValue;

            if(ALeft<=BRight  && BLeft<=ARight)
            {
                if(total%2 !=0)
                return Math.Max(ALeft,BLeft);
                else
                return (Math.Max(ALeft,BLeft)+Math.Min(ARight,BRight))/2.0;
            }

            else if(ALeft>BRight)
                r=AMid-1;
            else
                l=AMid+1;
        }
        return -1;
    }
}
