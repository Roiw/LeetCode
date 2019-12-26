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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        Queue<TreeNode> treesToSearch = new Queue<TreeNode>();
        HashSet<int> toDel = new HashSet<int>();
        IList<TreeNode> rtnList = new List<TreeNode>();
        // Prepare the dictionary to make things better later..
        for (int i  = 0; i < to_delete.Length; i++) {
            toDel.Add(to_delete[i]);
        }
        
        if (toDel.Contains(root.val)) {
            if (root.left != null)
                treesToSearch.Enqueue(root.left);
            if (root.right!= null)
                treesToSearch.Enqueue(root.right);
        }
        else
            treesToSearch.Enqueue(root);
        
        // Start finding..
        while (treesToSearch.Count > 0 ) {
            TreeNode currentRoot = treesToSearch.Dequeue();
            Queue<TreeNode> toSearch = new Queue<TreeNode>();
            if (toDel.Contains(currentRoot.val)){
                if (currentRoot.left != null)
                    treesToSearch.Enqueue(currentRoot.left);
                if (currentRoot.right!= null)
                    treesToSearch.Enqueue(currentRoot.right);
                 continue;
            }
                
            
            toSearch.Enqueue(currentRoot);
            
            while(toSearch.Count > 0) {
                TreeNode current = toSearch.Dequeue();
                
                if (current.left != null && toDel.Contains(current.left.val)) {
                    if (current.left.right != null)
                        treesToSearch.Enqueue(current.left.right);
                    if (current.left.left != null)
                        treesToSearch.Enqueue(current.left.left);
                    current.left = null;
                }
                else if (current.left != null){
                    toSearch.Enqueue(current.left);
                }
                if (current.right != null && toDel.Contains(current.right.val)) {
                    if (current.right.right != null)
                        treesToSearch.Enqueue(current.right.right);
                    if (current.right.left != null)
                        treesToSearch.Enqueue(current.right.left);
                    current.right = null;
                }
                else if (current.right != null) {
                    toSearch.Enqueue(current.right);
                }
            }
            rtnList.Add(currentRoot);
        }
        return rtnList;
    }
}