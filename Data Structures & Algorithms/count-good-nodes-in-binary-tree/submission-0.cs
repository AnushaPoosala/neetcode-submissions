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

public class Solution {
    
    public int GoodNodes(TreeNode root) 
    {
      return DFS(root,root.val); 
    }
    public int DFS(TreeNode root,int maxSoFar)
    {
         if(root==null)
            return 0;
        int count=0;
        if(root.val>=maxSoFar)
        {
            maxSoFar=root.val;
            count=1;
        }
        count=count+DFS(root.left,maxSoFar);
        count=count+DFS(root.right,maxSoFar);

        return count;
    }
    
   
}
