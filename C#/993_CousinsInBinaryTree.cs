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
    
    public bool IsCousins(TreeNode root, int x, int y) {

        int targetDepth = -1;
        TreeNode lastDad = null;
        Queue<(TreeNode, int, TreeNode)> queue = new Queue<(TreeNode, int, TreeNode)>();

        queue.Enqueue((root, 0, root));
               
        while (queue.Count > 0) {
            (TreeNode n, int depth, TreeNode dad) = queue.Dequeue();
            
            if (n.val == x || n.val == y){
                if (targetDepth == -1){
                    targetDepth = depth;
                    lastDad = dad;
                }
                else if (targetDepth == depth && lastDad != dad )
                    return true;
                else
                    return false;
            }
            if (targetDepth != -1 && depth > targetDepth )
                return false;
            
            if (n.left != null) queue.Enqueue((n.left, depth+1, n));
            if (n.right != null) queue.Enqueue((n.right, depth+1, n));
        }
        return false;
    }
}
