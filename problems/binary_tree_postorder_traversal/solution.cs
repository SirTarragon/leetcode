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
    public IList<int> PostorderTraversal(TreeNode root) {
        if(root == null) return new List<int>();
        if(root.right == null && root.left == null) return new List<int>(){root.val};

        var l = new List<int>();

        if(root.left != null) {
            l.AddRange(PostorderTraversal(root.left));
        }
        if(root.right != null) {
            l.AddRange(PostorderTraversal(root.right));
        }

        l.Add(root.val);

        return l;
    }
}