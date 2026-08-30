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
    public TreeNode InvertTree(TreeNode root) 
    {
        if(root==null)
        return root;
        
        Stack<TreeNode> sk=new Stack<TreeNode>();
        sk.Push(root);

        while(sk.Count!=0)
        {
            TreeNode node=sk.Pop();

            TreeNode temp=node.left;
            node.left=node.right;
            node.right=temp;

            if(node.left !=null)
                sk.Push(node.left);
            if(node.right!=null)
                sk.Push(node.right);
        }
        return root;
    }
}
