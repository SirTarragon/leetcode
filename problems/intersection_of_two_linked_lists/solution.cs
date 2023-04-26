/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null) return null;

        ListNode curA = headA, curB = headB;

        while(curA != curB && curA != null) {
            while(curA != curB && curB != null) {
                curB = curB.next;
            }
            if(curA != curB) {
                curB = headB;
                curA = curA.next;
            }
        }

        return curA;
    }
}