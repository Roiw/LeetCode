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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if (root == null){ return new TreeNode(val); }
        
        Insert(root,val); 
        return root;
    }
    
    private void Insert(TreeNode node, int val){
        if (val > node.val && node.right == null){
            node.right = new TreeNode(val);
            return; 
        }
        
        if (val < node.val && node.left == null){
            node.left = new TreeNode(val);
            return; 
        }
            
        if (val < node.val) 
            Insert(node.left, val);           
        else 
            Insert(node.right, val);        
    }
}
