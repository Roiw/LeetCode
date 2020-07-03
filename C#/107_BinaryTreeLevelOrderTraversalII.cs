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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        if (root == null) return new List<IList<int>>();
        
        Stack<IList<int>> ans = new Stack<IList<int>>();       
        Queue<(int,TreeNode)> q = new Queue<(int, TreeNode)>();
        
        q.Enqueue((0,root));
        while (q.Count > 0) {
            (int h, TreeNode node) = q.Dequeue();
            IList<int> lst = ans.Count > h? ans.Pop() : new List<int>(); 
            lst.Add(node.val);
            ans.Push(lst);
            if (node.left != null) q.Enqueue((h + 1, node.left));
            if (node.right != null) q.Enqueue((h + 1, node.right));
        }
        
        return ans.ToList();
    }
}
