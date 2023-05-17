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
    public int PairSum(ListNode head) {
        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode newHead = _reverse(slow);
        int max = 0;

        while(head != null && newHead != null){
            max = Math.Max(max, head.val + newHead.val);
            head = head.next;
            newHead = newHead.next;
        }

        return max;

        ListNode _reverse(ListNode head){
            ListNode newHead = null, temp = null;
            while(head != null){
                temp = head.next;
                head.next = newHead;
                newHead = head;
                head = temp;
            }
            return newHead;
        }
    }
}