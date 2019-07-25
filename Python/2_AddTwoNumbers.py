# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        a = 0
        b = 0
        i = 0
        
        while l1 != None:
            a =  a + l1.val * pow(10,i)
            i = i + 1
            l1 = l1.next
        print ("first number" + str(a))
               
        i= 0;
        while l2 != None:
            b =  b + l2.val * pow(10,i)
            i = i + 1
            l2 = l2.next
            
        print ("Second number" + str(b))
        total = a + b
        
        stringTotal = str(total)
        
        headOfList = ListNode(int(stringTotal[-1:]))
        listIterator = headOfList
        for c in range(len(stringTotal)-2, -1, -1):
                              newElem = ListNode(int(stringTotal[c]))
                              listIterator.next = newElem
                              listIterator = newElem
        return headOfList