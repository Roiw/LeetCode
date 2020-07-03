# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        a, b = "", ""
        while (l1 != None or l2 != None ):
            if l1 != None: 
                a = a + str(l1.val)
                l1 = l1.next
            if l2 != None:
                b = b + str(l2.val)
                l2 = l2.next
        
        s = str(int(a) + int(b))
        ans, last = None, None
        for i in range(len(s) - 1, -1, -1):
            ans = ListNode(int(s[i]), last)
            last = ans
            
        return ans
        
        