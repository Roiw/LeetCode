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

    Traversals: 
        Pre-Order: Root first, then Left and Right
        In-Order: Left, Root, then Right.
        Post-Order: Left, Right then Root.
    

    The Plan:
        - Dfs all the way to the left, print root than dfs right.

*/
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();
        
        if (root == null)
            return ans;
                
        ans.AddRange(InorderTraversal(root.left));
        ans.Add(root.val);
        ans.AddRange(InorderTraversal(root.right));
        return ans;
    }
}
