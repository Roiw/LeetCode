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
    public bool IsCompleteTree(TreeNode root) {
        Queue<TreeNode> toSearch = new Queue<TreeNode>();
        bool endOfTree = false;
        toSearch.Enqueue(root);
        while (toSearch.Count > 0) {
            TreeNode node = toSearch.Dequeue();
            
            if (node.left == null && node.right != null)
                return false;
            
            if (endOfTree && (node.left != null || node.right != null) )
                return false;
            
            if (node.right == null || node.left == null) {
                endOfTree = true;   
            }            
            
            if (node.left != null) toSearch.Enqueue(node.left);
            if (node.right != null) toSearch.Enqueue(node.right);
        }
        
        return true;
    }  
}
