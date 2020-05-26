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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null) return null;
        if (head.next == null) return head;
        ListNode node = new ListNode();
        node.next = head;
        int i = 0;
        // Count amount of elements..
        while (node.next != null){
            node = node.next;
            i++;
        }
        
        // In case we have a K bigger the the amount of elements
        k = k % i;
        int amount = i - k; // Define the amount of steps we must do before we disconect and reconnect the list.
        if (k == 0) return head; // No need to swap.
        
        // We navigate until the last element.
        ListNode last = new ListNode();
        last.next = head;
        i = 0;
        while (i < amount) {
            last = last.next;
            i++;
        }
        
        ListNode newHead = last.next;
        last.next = null;
        // Case newHead is the last element we don't need to fin the last element.
        if (newHead.next == null){
            newHead.next= head;
            return newHead;
        }
        // Find the last element and point it towards the head.    
        node = new ListNode();
        node.next = newHead.next;
        while (node != null){
            if (node.next == null){
                node.next = head;
                break;
            }
            node = node.next;
        }
        return newHead;
    }
}
