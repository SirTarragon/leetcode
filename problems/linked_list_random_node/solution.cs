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
    private int Length;
    private Random rand;
    private ListNode Head;

    public Solution(ListNode head) {
        Head = head;
        Length = 0;
        while(head != null) {
            Length++;
            head = head.next;
        }
        rand = new Random();
    }
    
    public int GetRandom() {
        int index = rand.Next(0, Length);
        ListNode cur = Head;
        while(index-- > 0)
            cur = cur.next;

        return cur.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */