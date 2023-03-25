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
    public ListNode ReverseList(ListNode head) {
        ListNode new_head = null;
        ListNode cur = head;
        ListNode next_node = null;
        while(cur != null) {
            next_node = cur.next;
            cur.next = new_head;
            new_head = cur;
            cur = next_node;
        }
        head = new_head;
        return head;
    }
}