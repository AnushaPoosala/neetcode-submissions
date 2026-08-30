public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        Dictionary<int, HashSet<char>> rows=new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols=new Dictionary<int, HashSet<char>>();
        Dictionary<string, HashSet<char>> sqrs=new Dictionary<string, HashSet<char>>();

        for(int r=0;r<9;r++)
        {
            for(int c=0;c<9;c++)
            {
                var curr=board[r][c];

                if(curr=='.')
                continue;
                
                string sqr=r/3+","+c/3;

                if((rows.ContainsKey(r) && rows[r].Contains(curr)) ||
                (cols.ContainsKey(c) && cols[c].Contains(curr))||
                (sqrs.ContainsKey(sqr) && sqrs[sqr].Contains(curr)))
                return false;

                if(!rows.ContainsKey(r))
                {
                    rows[r]=new HashSet<char>();
                }
                rows[r].Add(curr);

                if(!cols.ContainsKey(c))
                {
                    cols[c]=new HashSet<char>();
                }
                cols[c].Add(curr);

                if(!sqrs.ContainsKey(sqr))
                {
                    sqrs[sqr]=new HashSet<char>();
                }
                sqrs[sqr].Add(curr);
            }
        }
        return true;
    }
}
