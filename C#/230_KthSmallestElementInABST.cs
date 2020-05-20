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
    
    int _current = 0, _found = -1;
    public int KthSmallest(TreeNode root, int k) {     
        if (_current > k) return _found;
        if (root.left != null) KthSmallest(root.left, k);
        _current++;
        if (_current == k) _found = root.val; 
        if (root.right != null) KthSmallest(root.right, k);
        return _found;
    }
}
