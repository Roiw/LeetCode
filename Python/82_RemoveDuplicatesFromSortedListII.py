# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        it = head
        p0 = ListNode        
        p0.next = head
        # Run through the whole list.
        while it is not None:
            #if we find an element that its equal to the following
            if it.next is not None and it.val == it.next.val:
                val = it.val
                # I will advance until the I passed all elements
                while it is not None and it.val == val:
                    it = it.next
                # attribute to that element
                if p0.next == head:
                    head = it
                    p0.next = head
                else:
                    p0.next = it
            # Case it's different we keep going forward.
            else:                
                p0 = it
                it = it.next            
        return head
