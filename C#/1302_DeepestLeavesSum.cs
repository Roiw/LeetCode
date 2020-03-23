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
    public int DeepestLeavesSum(TreeNode root) {
        Queue<(int, TreeNode)> found = new Queue<(int, TreeNode)>();
        Dictionary<int,int> sumByLevel = new Dictionary<int,int>();
        int dl = 1;
        found.Enqueue((1,root));
        while(found.Count > 0){
            (int, TreeNode) I = found.Dequeue();
            if(sumByLevel.ContainsKey(I.Item1)) {
                sumByLevel[I.Item1] += I.Item2.val;
            }
            else {
                dl = I.Item1;
                sumByLevel.Add(I.Item1, I.Item2.val);
            }
            if (I.Item2.left != null)
                found.Enqueue((I.Item1 + 1, I.Item2.left));
            if (I.Item2.right != null)
                found.Enqueue((I.Item1 + 1, I.Item2.right));
        }
        return sumByLevel[dl];
    }
}