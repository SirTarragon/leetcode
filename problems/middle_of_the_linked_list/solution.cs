/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if(head == null) return null;
        List<ListNode> nodes = new List<ListNode>();
        ListNode cur = head;
        while(cur != null) {
            nodes.Add(cur);
            cur = cur.next;
        }
        return nodes[(int)Math.Ceiling((double)(nodes.Count/2))];
    }
}