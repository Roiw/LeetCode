/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int maxSize = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        DFS(root);
        return maxSize;
    }
    
    public int DFS (TreeNode root){
        // Base case..
        if (root.left == null && root.right == null)
            return 1;
        int left = 0, right = 0;
        
        if (root.left != null)
            left = DFS(root.left);
        if (root.right != null)
            right = DFS(root.right);
        
        maxSize = left + right > maxSize ? left + right : maxSize;
        
        return left > right ? left + 1: right + 1;
    }
}
