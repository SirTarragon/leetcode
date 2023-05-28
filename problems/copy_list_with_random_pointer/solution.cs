/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null) return null;
        Node newHead = new Node(head.val);
        Node cur = head.next;
        Node newCur = newHead;
        int length = 1;
        while(cur != null) {
            newCur.next = new Node(cur.val);
            newCur = newCur.next;
            cur = cur.next;
            length++;
        }
        cur = head;
        newCur = newHead;
        while(newCur != null) {
            if(cur.random == null) {
                newCur.random = null;
            } else {
                Node curR = cur.random;
                Node newR = newHead;
                int count = 0;
                while(curR != null) {
                    curR = curR.next;
                    count++;
                }
                for(int i = 0; i < length - count; i++) {
                    newR = newR.next;
                }
                newCur.random = newR;
            }
            cur = cur.next;
            newCur = newCur.next;
        }
        return newHead; 
    }
}