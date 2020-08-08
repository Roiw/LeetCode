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
    
    // An ugly structure, bear with me please...
    private SortedList<int, SortedList<int, List<int>>> _data = new  SortedList<int, SortedList<int, List<int>>>();
    
    private void Populate(TreeNode root, int x, int y) {
        
        if (!_data.ContainsKey(x)) {
            _data.Add(x, new SortedList<int, List<int>>());
            _data[x].Add(y, new List<int>());
            _data[x][y].Add(root.val);
        } else {
            if (!_data[x].ContainsKey(y)) {
                _data[x].Add(y, new List<int>());
                _data[x][y].Add(root.val);
            }
            else {
                // conflict..
                _data[x][y].Add(root.val);
                _data[x][y].Sort();
            }
        }
        
        if (root.left != null) Populate(root.left, x - 1, y + 1 );   
        if (root.right != null) Populate(root.right, x + 1, y + 1 );
    }
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
         _data = new  SortedList<int, SortedList<int, List<int>>>();
        Populate(root, 0, 0);
        List<IList<int>> ans = new List<IList<int>>();
        
        int i = 0;
        foreach( var yList in _data) {
            ans.Add(new List<int>());
            foreach(var lst in yList.Value) {
                foreach( var element in lst.Value) {
                    ans[i].Add(element);
                }
            }
            i++;
        }
        
        
        return ans;
    }
}