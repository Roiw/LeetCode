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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        Queue<(int, TreeNode)> queue = new Queue<(int, TreeNode)>();
        List<IList<int>> ans = new List<IList<int>>();
        if (root == null) return ans;
        
        queue.Enqueue((0, root));
        int currentDepth = 0;
        List<int> currentList = new List<int>();
        
        // BFS
        while (queue.Count > 0){
            (int depth, TreeNode n) = queue.Dequeue();
            
            // Changed depth..
            if (currentDepth != depth) {
                
                 // Normal -> evens
                if (currentDepth % 2 == 0) 
                    ans.Add(currentList);
                
                // Inversed -> odds
                else 
                    ans.Add(InvertList(currentList));
                
                currentList = new List<int>();
                currentDepth = depth;
            }
            
            // Continue BFS
            currentList.Add(n.val);
            if (n.left != null) queue.Enqueue((depth + 1, n.left));
            if (n.right != null) queue.Enqueue((depth + 1, n.right));
        }
        
        if (currentDepth % 2 == 0)
            ans.Add(currentList);
        else
            ans.Add(InvertList(currentList));
        
        return ans;
    }
    
    // Invert a list.
    private List<int> InvertList(List<int> lst){
        List<int> inversed = new List<int>();
        for (int i = lst.Count-1; i >= 0; i-- )
            inversed.Add(lst[i]);
        
        return inversed;
    }
}
