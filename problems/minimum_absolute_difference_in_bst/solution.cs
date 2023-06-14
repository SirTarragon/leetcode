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
    public int GetMinimumDifference(TreeNode root) {
        int difference = Int32.MaxValue;
        TreeNode previousNode = null;

        void traversal(TreeNode node) {
            if(node == null)
                return;
            
            traversal(node.left);
            if(previousNode != null)
                difference = Math.Min(difference, node.val - previousNode.val);
            previousNode = node;
            traversal(node.right);
        }

        traversal(root);
        return difference;
    }
}