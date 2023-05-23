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
    public string Tree2str(TreeNode root) {
        if(root == null) return "";
        string tree = $"{root.val}";
        if(root.left != null)
            tree += $"({Tree2str(root.left)})";
        if(root.left == null && root.right != null)
            tree += $"()({Tree2str(root.right)})";
        else if(root.right != null)
            tree += $"({Tree2str(root.right)})";
        return tree;
    }
}