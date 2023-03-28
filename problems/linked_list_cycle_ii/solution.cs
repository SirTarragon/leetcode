/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null) return null;
        Dictionary<ListNode,int> directory = new Dictionary<ListNode,int>();
        ListNode cur = head;
        for(int i = 0; cur.next != null; i++, cur = cur.next) {
            if(directory.ContainsKey(cur)) return cur;
            else {
                directory.Add(cur, i);
            }
        }
        return null;
    }
}