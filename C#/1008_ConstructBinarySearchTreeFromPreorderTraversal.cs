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
    public TreeNode BstFromPreorder(int[] preorder) {
        TreeNode root = new TreeNode(preorder[0]);
        for (int i = 1; i < preorder.Length; i++){
            AddNode(root, new TreeNode(preorder[i]));
        }
        return root;
    }
    
    public void AddNode(TreeNode root, TreeNode member){
        if (member.val < root.val){
            if (root.left == null)
                root.left = member;
            else
                AddNode(root.left, member);
        }
        else if (member.val > root.val){
            if (root.right == null)
                root.right = member;
            else
                AddNode(root.right, member);
        }
        return; // If its equal we discard..
    }
}
