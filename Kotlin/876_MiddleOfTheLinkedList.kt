/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        List<ListNode> nodes = new List<ListNode>();
        ListNode current = head;
        nodes.Add(head);
        while (current != null){
            if (current.next != null) nodes.Add(current.next) ;
            current = current.next;
        }     
        return nodes[nodes.Count/2];
    }
}
