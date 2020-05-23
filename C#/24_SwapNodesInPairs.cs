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
    public ListNode SwapPairs(ListNode head) {
        if (head == null) return null;
        ListNode it = new ListNode();
        it.next = head.next;
        it.val = head.val;
        
        if (head.next != null)
            head = head.next;
        else
            return head;
        
        bool shouldSwap = true;
        while (it.next != null) {
            if (shouldSwap){
                ListNode n = it.next;
                it.next = n.next;
                n.next = it;
                shouldSwap = false;        
            }
            else {
                shouldSwap = true;
                ListNode i = it.next;
                it.next = it.next.next != null ? it.next.next: it.next;
                it = i;
            }
        }
        return head;
    }
}
