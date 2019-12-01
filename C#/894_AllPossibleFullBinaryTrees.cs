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
    public IList<TreeNode> AllPossibleFBT(int N) {
        
         IList<TreeNode> rtn = new List<TreeNode>();
        
        // Special case
        if (N % 2 == 0)
            return new List<TreeNode>();
        
        if (N == 1) {
            TreeNode elem = new TreeNode(0);
            rtn.Add(elem);
            return rtn;
        }    
        
        // Start for every possibility
        
        for (int i = 1; i < N; i = i + 2) {
            
            IList<TreeNode> leftParents = AllPossibleFBT(i);
            IList<TreeNode> rightParents = AllPossibleFBT(N - (i + 1));
            
            // Do a combination of possible outcomes..
            foreach (TreeNode l in leftParents) {
                foreach(TreeNode r in rightParents) {
                    TreeNode parentOfParents = new TreeNode(0);
                    parentOfParents.left = l;
                    parentOfParents.right = r;
                    rtn.Add(parentOfParents);
                }
            }       
        }   
        return rtn;
    }
}