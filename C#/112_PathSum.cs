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
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null)
            return false;
        
        return FindPath(root, sum, 0);
    }
    
    public bool FindPath(TreeNode root, int sum, int curr) {
        curr += root.val;
        if (root.left == null && root.right == null) {
            if (curr == sum)
                return true;
            else
                return false;
        }
        
        bool rtn = false;
        if (root.left != null)
            rtn = FindPath(root.left, sum, curr);
        if (!rtn && root.right != null)
            rtn = FindPath(root.right, sum, curr);
        
        return rtn;
    }
}
