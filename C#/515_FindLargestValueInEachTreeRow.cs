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
    public IList<int> LargestValues(TreeNode root) {
        if (root == null) return new List<int>();
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        List<int> ans = new List<int>();
        queue.Enqueue((root, 0));
        
        int currentDepth = 0;
        int maxInDepth = root.val;
        
        // Traversing..
        while (queue.Count > 0) {
            (TreeNode n, int depth) = queue.Dequeue();
            
            // Finished a row (depth)..
            if (depth > currentDepth){
                ans.Add(maxInDepth);
                currentDepth = depth;
                maxInDepth = Int32.MinValue;
            }
            
            maxInDepth = n.val > maxInDepth ? n.val : maxInDepth;
            
            if (n.left != null) queue.Enqueue((n.left, depth + 1));
            if (n.right != null) queue.Enqueue((n.right, depth + 1));
        }
        ans.Add(maxInDepth);
        return ans;
    }
}
