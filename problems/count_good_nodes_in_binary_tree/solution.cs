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
    public int GoodNodes(TreeNode root) {
        int countGood = 0;

        void Traverse(int previous, TreeNode node)
        {
            if(node == null) return;
            
            if(node.val >= previous) {
                countGood++;
                previous = node.val;
            }

            Traverse(previous, node.right);
            Traverse(previous, node.left);
        }

        Traverse(root.val, root);

        return countGood;
    }
}