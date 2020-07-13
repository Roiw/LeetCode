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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        List<int> pTraverse = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        while (queue.Count > 0) {
            TreeNode v = queue.Dequeue();
            pTraverse.Add(v == null? -1 : v.val);
            if (v == null) continue;
            queue.Enqueue(v.left);
            queue.Enqueue(v.right);
        }
        // Checking next tree..
        queue.Enqueue(q);
        int c = 0;
        while (queue.Count > 0) {
            TreeNode v = queue.Dequeue();
            int vVal = v == null? -1 : v.val;
            if (pTraverse[c] != vVal) return false;
            c++;
            if (v == null) continue;
            queue.Enqueue(v.left);
            queue.Enqueue(v.right);
        }
        return true;
    }
}
