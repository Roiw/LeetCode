/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private Queue<(int, int)> _nodes = new Queue<(int,int)>();
    
    public TreeNode RecoverFromPreorder(string S) {
        int index = 0;
        int initial  = 0;
        (initial, index) = GetNumber(S, index);       
        
        // Map string to Queue..
        while (index < S.Length) {
            int depth = CountDash(S, index);
            index += depth;
            int number = 0;
            (number, index) = GetNumber(S, index);    
            _nodes.Enqueue((depth, number));
        }
        
        TreeNode root = new TreeNode();
        root.val = initial;
        Navigate(root,0);
        
        return root;
    }
    
    private void Navigate(TreeNode curr, int depth) {
        if (_nodes.Count == 0) return;
        (int currentDepth,  int number) = _nodes.Peek();
        
        // Go left..
        if (currentDepth > depth){
             _nodes.Dequeue();
            curr.left = new TreeNode();
            curr.left.val = number;
            Navigate(curr.left, depth + 1);
        }
        
        // Go right..
        if (_nodes.Count == 0) return;
        (currentDepth, number) = _nodes.Peek();
        if (currentDepth > depth){
            _nodes.Dequeue();
            curr.right = new TreeNode();
            curr.right.val = number;
            Navigate(curr.right, depth + 1);
        }    
    }
    
    
    private int CountDash(string S, int index){
        int dashes = 0;
        while(S[index] == '-') {
            dashes++;
            index++;
        }
        return dashes;
    }
    
    private (int, int) GetNumber(string S, int index){
        string number = "";
        while(index < S.Length && S[index] >= '0' && S[index] <= '9') {
            number += S[index];
            index++;
        }
        return (Int32.Parse(number), index);
    }
}
