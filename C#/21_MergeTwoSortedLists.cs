/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        // Checking for nulls..
        if (l1 == null)
            return l2;
        else if (l2 == null)
            return l1;
        
        // checking the first element..
        ListNode merged;
        ListNode currentL1 = l1;
        ListNode currentL2 = l2;
        if (l1.val >= l2.val) {
            merged = new ListNode(l2.val);
            currentL2 = l2.next;
        } else {
            merged = new ListNode(l1.val);
            currentL1 = l1.next;
        } 
        ListNode current = merged;
        
        while (currentL1 != null || currentL2 != null) {
            if ( currentL1 == null) {
                current.next = new ListNode(currentL2.val);
                current = current.next;
                currentL2 = currentL2.next;     
            }
            else if ( currentL2 == null) {
                current.next = new ListNode(currentL1.val);
                current = current.next;
                currentL1 = currentL1.next;       
            }
            else if (currentL1.val >= currentL2.val) {
                current.next = new ListNode(currentL2.val);
                current = current.next;
                currentL2 = currentL2.next;    
            }
            else {
                current.next = new ListNode(currentL1.val);
                current = current.next;
                currentL1 = currentL1.next;    
            }       
         }
         return merged;	        
    }
}