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
    public ListNode OddEvenList(ListNode head) {
        if (head == null) return null;
        if (head.next == null) return head;
        
        ListNode even = head.next;
        ListNode odd = head;
        ListNode headEven = even;
        while (true) {
            if (odd.next != null && odd.next.next != null){
                odd.next = odd.next.next;
                odd = odd.next;
            }               
            else
                odd.next = null;

            if (even.next != null && even.next.next != null){
                even.next = even.next.next;
                even = even.next;
            }
            else
                even.next = null;
            
            if (even.next == null && odd.next == null){
                odd.next = headEven;
                break;
            }            
        }
        return head;
    }
}
