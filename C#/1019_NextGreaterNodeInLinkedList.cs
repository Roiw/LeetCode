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

// We keep a stack to remember which elements are missing a 'Next Greater Value'
// For example [4, 3], both elements are missing a 'Next Greater Value'
// We store them in the stack as pairs (element, index). In this case {(4,0),(3,1)}
// Whenever we find a bigger element we Peek from the stack and see if we can satisfy that 'slot'
// If so we Pop and update the element in the List.
public class Solution {
    public int[] NextLargerNodes(ListNode head) {
        Stack<(int,int)> nodes = new Stack<(int,int)>();
        ListNode node = head;
        List<int> ans = new List<int>();
        int index = 0;
        while (node != null){
            while(nodes.Count > 0 && nodes.Peek().Item1 < node.val){
                ans[nodes.Pop().Item2] = node.val;
            }
            ans.Add(0); // We add an 0 for the current element.
            nodes.Push((node.val,index));
            node = node.next;
            index++;
        }    
        return ans.ToArray();
    }
}
