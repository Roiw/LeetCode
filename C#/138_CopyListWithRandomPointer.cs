/*

// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}

*/

public class Solution {
    
    private Node CloneNode (Node node) {
        Node n = new Node(node.val);
        n.next = node.next;
        n.random = node.random;
        return n;
    }
    
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        
        Dictionary<Node, Node> pairs = new Dictionary<Node,Node>();
        
        Node n = CloneNode(head);
        pairs.Add(head, n);
        
        Node nHead = new Node(0);
        nHead.next = n;
        
        // First run, clone the list based on next.
        while (n != null){
            Node next = null;
            if (n.next != null){
                next = CloneNode(n.next);
                pairs.Add(n.next, next);
            }
            n.next = next;
            n = next;
        }
        
        n = nHead.next;       
        
        // Second random
        while ( n != null ) {
            if (n.random != null){
                n.random = pairs[n.random];
            }
            n = n.next;
        }
        
        return nHead.next;
            
    }
}
