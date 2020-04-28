/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> lst = new List<int>();
    public IList<int> Postorder(Node root) {        
        if (root == null) return lst;
            
        Traverse(root);
        return (IList<int>) lst;
    }
    
    public void Traverse(Node r) {
        
        if (r.children.Count == 0 ) {
            lst.Add(r.val);
            return;
        }
            
        foreach (Node n in r.children)
            Traverse(n);    
        
        lst.Add(r.val);
    }
}
