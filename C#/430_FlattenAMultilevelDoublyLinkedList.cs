/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
	private Stack<Node> stack = new Stack<Node>();
    public Node Flatten(Node head) {
        if (head == null) return null;
		Node next = head.next;
		if (head.child != null){
			Node branchTail = Flatten(head.child);
			Node branchHead = stack.Pop();
			if (next!= null) next.prev = branchHead;
			branchHead.next = next;
			next = branchTail;
			head.next = branchTail;
			branchTail.prev = head;
		}
        head.child = null;
		next = Flatten(next);
		if (next != null) {
			head.next = next;
			next.prev = head;
		} else stack.Push(head);		
		return head;
    }
}
