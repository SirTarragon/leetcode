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
    public int MaxLevelSum(TreeNode root) {
        var level_sums = new List<int>();
        void dfs(TreeNode node, int level) {
            if (node == null)
                return;

            if (level_sums.Count == level)
                level_sums.Add(node.val);
            else
                level_sums[level] += node.val;

            dfs(node.left, level + 1);
            dfs(node.right, level + 1);
        }

        dfs(root, 0);

        return 1 + level_sums.IndexOf(level_sums.Max());
    }
}