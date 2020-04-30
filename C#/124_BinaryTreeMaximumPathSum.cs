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
    private int _max = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        Navigate(root);
        return _max;
    }
    
    public int Navigate(TreeNode root){
        // Base case
        if (root.left == null && root.right == null){
            _max = root.val > _max ? root.val : _max;
            return root.val;
        }
            
        int left = 0, right = 0;
        if (root.left != null){
            left = Navigate(root.left);
            left = left + root.val > root.val ? left : 0;
        }
 
        if (root.right != null){
            right = Navigate(root.right);
            right = right + root.val > root.val ? right : 0;
        }
        
        int total = right + left + root.val;
        _max = total > _max ? total : _max;
        return right > left? root.val + right: root.val + left;
    }
}
