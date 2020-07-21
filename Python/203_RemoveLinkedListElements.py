# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeElements(self, head: ListNode, val: int) -> ListNode:
        # Edge case list is empty
        if head == None: return head
        # Find a valid head.
        while head.val == val:
            head = head.next
            if head == None: return head      
        # Start from the head.
        p1 = ListNode(head.val, head.next)
        head.next = p1
        # While we can, advance to next element that is acceptable.
        while p1:
            if p1.next and p1.next.val == val: 
                p1.next = p1.next.next
                continue
            p1 = p1.next
        return head.next
        