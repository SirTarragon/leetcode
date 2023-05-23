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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode tempHead = new ListNode(0, head);
        ListNode cur = tempHead, end = tempHead;
        
        for(int i = 0; i < n && end.next != null; i++)
            end = end.next;
        
        while(end.next != null) {
            cur = cur.next;
            end = end.next;
        }

        cur.next = cur.next.next;

        return tempHead.next;
    }
}