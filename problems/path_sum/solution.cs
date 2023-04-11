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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return Traversal(root, targetSum, 0);
    }

    public bool Traversal(TreeNode node, int targetSum, int counter = 0) {
        if(node == null) return false;
        counter += node.val;
        if(node.left == null && node.right == null)
            return (counter == targetSum);

        if(node.left != null)
            if(Traversal(node.left, targetSum, counter)) return true;
        
        if(node.right != null)
            if(Traversal(node.right, targetSum, counter)) return true;

        return false;
    }
}