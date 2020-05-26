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
    public int RangeSumBST(TreeNode root, int L, int R) {
        int amount = root.val >= L && root.val <= R ? root.val : 0;
        
        if (root.left != null && root.val >= L){
            amount += RangeSumBST(root.left,L,R);
        }
        if (root.right != null && root.val <= R){
            amount += RangeSumBST(root.right,L,R);
        }
        return amount;
    }
}
