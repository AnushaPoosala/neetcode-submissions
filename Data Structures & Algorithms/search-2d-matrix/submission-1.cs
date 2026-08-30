public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows=matrix.Length; 
        int clos=matrix[0].Length; int l=0;
        int r=(rows*clos)-1;
        while(l<=r)
        {
            int mid=l+((r-l)/2);
            int col=mid%clos;
            int row=mid/clos;
            int midEle=matrix[row][col];
            Console.WriteLine(midEle);

            if(target==midEle)
            return true;

            else if(midEle<target)
            {
                l=mid+1;
            }
            else
            {
                r=mid-1;
            }
        }
        return false;
    }
}
