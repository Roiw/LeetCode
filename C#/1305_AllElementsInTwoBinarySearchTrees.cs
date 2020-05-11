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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        List<int> side1  = new List<int>();
        List<int> side2  = new List<int>();
        
        Navigate(root1, side1);
        Navigate(root2, side2);
        
        side1.AddRange(side2);        
        side1.Sort();
        
        return (IList<int>) side1;  
    }
    
    private void Navigate(TreeNode root, List<int> rtn) {
        if (root == null) return;
        
        if (root.left == null && root.right == null){
            rtn.Add(root.val);
            return;
        }           
        
        if (root.left != null)
            Navigate(root.left, rtn);
        if (root.right != null)
            Navigate(root.right, rtn);
        
        rtn.Add(root.val);
    }
}
