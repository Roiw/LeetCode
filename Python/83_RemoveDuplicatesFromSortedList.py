# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        if head is None: return None
        beforeHead = ListNode(0, head)
        while head is not None:
            if head.next is not None and head.val == head.next.val:
                head.next = head.next.next
            else:
                head = head.next
  
        return beforeHead.next