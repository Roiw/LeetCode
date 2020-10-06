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

/*
    Make a BFS
*/
public class Solution {
    public bool IsEvenOddTree(TreeNode root) {
        if (root == null) return false;
        if (root.val % 2 == 0) return false;
        
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        
        if (root.left != null) queue.Enqueue((root.left, 1));
        if (root.right != null) queue.Enqueue((root.right, 1));
        
        int lastHeight = 0;
        int currentValue = 0;
        
        while (queue.Count > 0) {
            (TreeNode node, int height) = queue.Dequeue();
            
            if (height > lastHeight) {
                lastHeight = height;
                currentValue = node.val;
                if (height % 2 == 0 && node.val % 2 == 0) return false;
                if (height % 2 == 1 && node.val % 2 == 1) return false;
            }
            else {
                // Verify node.
                if (height % 2 == 0) {
                    // Verify even
                    if (node.val <= currentValue || node.val % 2 == 0) 
                        return false;
                } 
                else {
                    // Verify odd
                    if (node.val >= currentValue || node.val % 2 == 1) 
                        return false;
                }
                currentValue = node.val;
            }
            
            if (node.left != null) queue.Enqueue((node.left, height + 1));
            if (node.right != null) queue.Enqueue((node.right, height + 1));
        }
        return true;
    }
}
