public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        Dictionary<int,HashSet<char>> rows=new Dictionary<int,HashSet<char>>();
        Dictionary<int,HashSet<char>> cols=new Dictionary<int,HashSet<char>>();
        Dictionary<string,HashSet<char>> sqrs=new Dictionary<string,HashSet<char>>();
        //Key row no. value: row elemnts
        //if any value repeats returns false
        //row: 1  value 4,

        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                rows[i]=new HashSet<char>();
                cols[j]=new HashSet<char>();
                
            }
        }

        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                char curr=board[i][j];
                string sqrkey=(i/3+","+j/3);

                if(curr=='.')
                continue;

                if(
                (rows.ContainsKey(i) && rows[i].Contains(curr)) ||  
                (cols.ContainsKey(j) && cols[j].Contains(curr)) ||
                (sqrs.ContainsKey(sqrkey) && sqrs[sqrkey].Contains(curr))
                )
                return false;

                rows[i].Add(curr) ; 
                cols[j].Add(curr); 

                if(! (sqrs.ContainsKey(sqrkey) ))
                sqrs[sqrkey]=new HashSet<char>();
                sqrs[sqrkey].Add(curr);      
            }

        }
        return true;


    }
}
