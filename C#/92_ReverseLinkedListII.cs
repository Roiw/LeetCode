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
    // 10
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        
        ListNode prev = null;
        ListNode curr = head;
        ListNode next = null;
        ListNode last = null; // N
        ListNode first = null; // M
            
        
        for (int k = 1; k < m; k++){
            prev = curr;
            curr = curr.next;
        }
            
        // curr is at start of swaps.
        int i = m;
        first = prev; // M -1
        last = curr;  // M
        prev = curr;
        curr = curr.next;
        while (i < n){        
            if (curr != null){
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            i++;
        }
        
        // The last two connections (before and after interval respectively.)
        if (first != null) first.next = prev; // First can be null if M == 1
        last.next = curr;
        
        return m > 1? head : prev;
    }
}
