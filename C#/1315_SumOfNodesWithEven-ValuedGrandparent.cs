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
    int _total = 0;
    public int SumEvenGrandparent(TreeNode root) {
        Navigate(root, false);
        return _total;
    }
    
    private void Navigate (TreeNode node, bool parentEven){
        if (node.left == null && node.right == null)
            return;
        
        if (node.left != null){
            if (parentEven)
                _total += node.left.val;
            Navigate(node.left, node.val % 2 == 0);
        }
        
        if (node.right != null){
            if (parentEven)
                _total += node.right.val;
            Navigate(node.right, node.val % 2 == 0);
        }   
    }
}
