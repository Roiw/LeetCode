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
// O(N), O(1). 
// Step1: Count amount of elements in list
// Step2: Revert the other of half ot the list 1->2->2->1 becomes 1->2->2<-1
// Step3: From both ends compare elements and move towards the center.
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null) return true;
        int count = 1;
        int aux = 0;
        
        // Count amount of  nodes..
        ListNode node = new ListNode(head.val, head.next);
        while (node.next != null) { count++; node = node.next;}
        
        // Revert half the list.
        ListNode endNode = new ListNode(head.val, head.next);    
        ListNode next = endNode.next;
        while (next != null) {
            if (aux >= count/2) { 
                ListNode nextNext = next.next;
                next.next = endNode;
                endNode = next;
                next = nextNext;
            }
            else {
                endNode = next;
                next = next.next;
                aux++;
            }
        }
        
        // Check the palindrome
        node = new ListNode(head.val, head.next);
        aux = 0;
        while (aux < count/2){
            if (node.val != endNode.val) return false;
            node = node.next;
            endNode = endNode.next;
            aux++;
        }    
        return true;
    }
}