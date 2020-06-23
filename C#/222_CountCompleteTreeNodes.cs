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
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int count = 0;
        while(queue.Count > 0){
            TreeNode tn = queue.Dequeue();
            count++;
            if (tn.left != null) queue.Enqueue(tn.left);
            if (tn.right != null) queue.Enqueue(tn.right);
            if (tn.left == null || tn.right == null) {
                count += queue.Count;
                break;
            }
        }
        return count;
    }

}
