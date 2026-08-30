/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution 
{
    public bool IsBalanced(TreeNode root) 
    {
        if(Height(root)!=-1)
            return true;
        else
            return false;
    }
    private int Height(TreeNode root)
    {
        if(root==null)
            return 0;

        int LSH=Height(root.left);
        if(LSH==-1)
            return -1;

        int RSH=Height(root.right);
        if(RSH==-1)
            return -1;

        if(Math.Abs(LSH-RSH)>1)
            return -1;

        return Math.Max(LSH,RSH)+1;
    }
}
