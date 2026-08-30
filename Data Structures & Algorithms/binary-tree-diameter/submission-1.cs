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
    private int _diameter=0;
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        DiameterOfEachNode(root);
        return _diameter;
    }
    private int DiameterOfEachNode(TreeNode root)
    {
        if(root==null)
            return 0;
        
        int leftSubTreeHeight=DiameterOfEachNode(root.left);
        int rightSubTreeHeight=DiameterOfEachNode(root.right);

        _diameter=Math.Max(leftSubTreeHeight+rightSubTreeHeight,_diameter);

        return Math.Max(leftSubTreeHeight,rightSubTreeHeight)+1;
    }
}
