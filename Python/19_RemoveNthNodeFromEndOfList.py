# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: ListNode, n: int) -> ListNode:
        it, count = head, 1
        p0 = ListNode()
        p0.next = head
        while it.next is not None:
            if count == n:
                p0 = p0.next
            else:
                count += 1
                        
            it = it.next
        
        if p0.next == head:
            return head.next                    
        else:
            p0.next = p0.next.next
            
        return head
                