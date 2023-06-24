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
    public bool IsCousins(TreeNode root, int x, int y) {
        int rootHash = root.GetHashCode();
        int[] lvl = new int[2] {-1, -1}; // x and y lvl record
        int[] parentHash = new int[2] {rootHash, rootHash};

        void DFS(TreeNode node, int level, TreeNode previous) {
            if(node == null) return;
            else if(lvl[0] != -1 && lvl[1] != -1) return;

            if(node.val == x) {
                lvl[0] = level;
                parentHash[0] = previous.GetHashCode();
            }
            else if(node.val == y) {
                lvl[1] = level;
                parentHash[1] = previous.GetHashCode();
            }
            
            if(lvl[0] != -1 && lvl[1] != -1) return;
            DFS(node.left, level + 1, node);
            DFS(node.right, level + 1, node);
        }

        DFS(root, 0, root);

        return lvl[0] == lvl[1] && (parentHash[0] != parentHash[1]);
    }
}