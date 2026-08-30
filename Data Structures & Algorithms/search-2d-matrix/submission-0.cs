public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int rowsCount=matrix.Length; int colsCount=matrix[0].Length;
        int eleCount=rowsCount*colsCount;
        int l=0; int r=eleCount-1;
       
        while(l<=r)
        {
            int mid=l+(r-l)/2;
            int row=mid/colsCount;
            int col=mid%colsCount;

            if(matrix[row][col]==target)
            return true;
            else if(matrix[row][col]>target)
            r=mid-1;
            else
            l=mid+1;
        }
        

        return false;
    }
}
