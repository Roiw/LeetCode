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
    public bool IsPalindrome(ListNode head) {
        if (head == null) return true;
        int count = 1;
        int aux = 0;
        Stack<int> stck = new Stack<int>();
        
        ListNode node = new ListNode(head.val, head.next);
        while (node.next != null) { count++; node = node.next;}
        
        node = new ListNode(head.val, head.next);    
        while (node != null) {
            if (aux < count/2) {stck.Push(node.val);}
            else if (count % 2 == 0 && aux == count/2 || aux > count/2) {
                if ( stck.Pop() != node.val) return false; 
            }
            node = node.next;
            aux++;
        }
        return true;
    }
}
