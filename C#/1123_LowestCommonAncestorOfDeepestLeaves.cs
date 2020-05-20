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
    
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        int dRight = 0;
        int dLeft = 0;
        
        if (root.left != null) dLeft = CountDepth(root.left);
        if (root.right != null) dRight = CountDepth(root.right);
        
        if (dLeft == dRight) return root;
        if (dLeft > dRight) return LcaDeepestLeaves(root.left);
        else return LcaDeepestLeaves(root.right);
    }
    
    private int CountDepth(TreeNode root){
        if (root.left == null && root.right == null)
            return 1;
        
        int dRight = 0, dLeft = 0;
        if (root.right != null) dRight = CountDepth(root.right);
        if (root.left != null) dLeft = CountDepth(root.left);
        return Math.Max(dRight,dLeft) + 1;
    }
}
