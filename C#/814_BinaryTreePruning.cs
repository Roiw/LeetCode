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
    
    private bool Prune (TreeNode node) {
        
        bool resultLeft = true;
        bool resultRight = true;
        
        if (node.left != null){
            resultLeft = Prune(node.left);
            node.left = resultLeft? null: node.left;
        }
        if (node.right != null){
            resultRight = Prune(node.right);
            node.right = resultRight? null: node.right;
        }
        
        if (resultLeft && resultRight && node.val == 0)
            return true;
        
        return false;
    }
    
    public TreeNode PruneTree(TreeNode root) {
        if (Prune(root))
            return null;
        return root;
    }
}
