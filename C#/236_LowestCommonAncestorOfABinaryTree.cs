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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        Stack<TreeNode> pPath = DFS(root, p);
        Stack<TreeNode> qPath = DFS(root, q);
        
        int smallerLength = pPath.Count >= qPath.Count? qPath.Count: pPath.Count;
        
        TreeNode LCA = root;
        for(int i = 0; i < smallerLength; i++) {
            TreeNode pElem = pPath.Pop();
            TreeNode qElem = qPath.Pop();
            if (pElem == qElem)
                LCA = pElem;
            else
                break;
        }
        
        return LCA;
            
    }
    
    public Stack<TreeNode> DFS(TreeNode root, TreeNode target) {
        
        if (root == target)
            return new Stack<TreeNode>(new TreeNode[] {root});
        
        if (root.left == null && root.right == null)
            return null;
        
        Stack<TreeNode> pathFound = null;
        if (root.left != null)
           pathFound = DFS(root.left, target);
        
        if (root.right != null && pathFound == null)
            pathFound = DFS(root.right, target);
        
        if (pathFound != null)
            pathFound.Push(root);
        
        return pathFound;        
    }
}