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
    public Node Flatten(Node head) {
        if (head == null) return null;
        return Flat(head, head.next);
    }
    private Node Flat(Node head, Node next) {
        head.next = next;
        if (next == null) return head;
        next.prev = head;
        Node newNext = next.next;
        if (next.child != null) next = Flat(next, next.child);
        return Flat(next, newNext);
    }
}
