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
    private int total = 0;
    private HashSet<TreeNode> startedFrom = new HashSet<TreeNode>();
    private void DFS(TreeNode root, int sum, int target) {
        sum += root.val;
        startedFrom.Add(root);
        if (sum == target) total++;
        if (root.left != null  && !startedFrom.Contains(root.left))
            DFS(root.left, 0 , target);
        if (root.left != null) DFS(root.left, sum , target);
        if (root.right != null && !startedFrom.Contains(root.right))
            DFS(root.right, 0 , target);
        if (root.right != null) DFS(root.right, sum , target);
    }
    public int PathSum(TreeNode root, int sum) {
        if (root == null) return 0;
        total = 0;
        DFS(root, 0, sum);
        return total;
    }
}
