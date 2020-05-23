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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        List<ListNode> lst = new List<ListNode>();
        ListNode it = new ListNode();
        it.next = head.next;
        
        lst.Add(head);
        while(it.next != null){
            lst.Add(it.next);
            it = it.next;
        }
        
        int k = lst.Count - n -1;
        
        if (k < 0) 
            return lst[0].next;
        
        lst[k].next = lst[k].next.next;
        return head;
    }
}
