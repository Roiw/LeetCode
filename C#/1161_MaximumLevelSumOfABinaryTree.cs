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
    public int MaxLevelSum(TreeNode root) {
        Queue<(TreeNode, int)> toProcess = new Queue<(TreeNode, int)>();
        List<int> maximums = new List<int>(){0};
        
        toProcess.Enqueue((root, 1));
        
        while (toProcess.Count > 0){
            (TreeNode n, int level) = toProcess.Dequeue();
            
            if (maximums.Count < level + 1)
                maximums.Add(n.val);
            else
                maximums[level] += n.val;
            
            if (n.left != null)
                toProcess.Enqueue((n.left, level + 1));
            if (n.right != null)
                toProcess.Enqueue((n.right, level + 1));
        }
        
        int max = Int32.MinValue;
        int answer = -1;
        for (int i = 0; i < maximums.Count; i++){
            if (maximums[i] > max) {
                max = maximums[i];
                answer = i;
            }
        }
        
        return answer;
    }
}
