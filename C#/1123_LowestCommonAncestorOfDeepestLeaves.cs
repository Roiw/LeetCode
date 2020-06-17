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
    
    // If depths are equal -> found correct node.
    // If bigger than other -> dig on bigger node..

    private Dictionary<TreeNode, (int,int)> _adapt = new Dictionary<TreeNode, (int,int)>();
    public TreeNode LcaDeepestLeaves(TreeNode root) {    
        if (!_adapt.ContainsKey(root)) CountDepth(root);
        (int left, int right) = _adapt[root];
        
        if (left > right) return LcaDeepestLeaves(root.left);
        if (right > left) return LcaDeepestLeaves(root.right);
        return root;
    }
    
    private int CountDepth(TreeNode root){
        int left = 1, right = 1;
        if (root.left != null) left += CountDepth(root.left);
        if (root.right != null) right += CountDepth(root.right);
        _adapt.Add(root, (left,right));
        return Math.Max(left,right);
    }
}
