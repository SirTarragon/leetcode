# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        def recur(right):
            if not right.next:
                return head.val + right.val, head.next

            best, left = recur(right.next)            
            return max(best, left.val + right.val), left.next

        return recur(head)[0]