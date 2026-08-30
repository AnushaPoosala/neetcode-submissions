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
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        if(root==null)
           return 0;

        int leftSubTreeDiameter=DiameterOfBinaryTree(root.left);
        int rightSubTreeDiameter=DiameterOfBinaryTree(root.right);

        int height=Height(root.left)+Height(root.right);

        return Math.Max(Math.Max(leftSubTreeDiameter,rightSubTreeDiameter),height); 
        
    }
    public int Height(TreeNode root)
    {
        if(root==null)
        return 0;

        int leftSubTreeHeight=Height(root.left);
        int rightSubTreeHeight=Height(root.right);

        return Math.Max(leftSubTreeHeight,rightSubTreeHeight)+1;
    }
}
