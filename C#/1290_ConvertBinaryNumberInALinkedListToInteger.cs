/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        ListNode i = head;
        int count = 0, ans = 0;
        while (i != null) { 
            count++; i = i.next;
        }
        i = head;
        while (i != null) { 
            ans += (int)Math.Pow(2, (count-1)) * i.val;
            count--;
            i = i.next;
        }
        return ans;
    }
}
