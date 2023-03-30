/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        if(root == null) return new List<int>();
        if(root.children.Count == 0) return new List<int>(){root.val};
        IList<int> vals = new List<int>();
        vals.Add(root.val);
        foreach(Node cur in root.children) {
            vals = vals.Concat(Preorder(cur)).ToList();
        }
        return vals;
    }
}