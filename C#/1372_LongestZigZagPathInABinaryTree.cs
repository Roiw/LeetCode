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

/*

    - DFS : O(N)
    - Navigate down the tree and return two possibilities (left and right) 
    
*/

public class Solution {
    
    int _max;
    
    public (int, int) DFS(TreeNode node) {
        if (node == null)
            return (0,0);
        
        (int right, int unused) = DFS(node.left);
        (int unused2, int left) = DFS(node.right);
        
        _max = Math.Max( Math.Max( right, left ), _max);
        
        left += 1;
        right += 1;
        
        return (left, right);
    }
    
    public int LongestZigZag(TreeNode root) {
        _max = 0;
        DFS(root);
        return _max;
    }
}
