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
    enum Instructions { Left, Right }
    private Stack<Instructions> _toDo = new Stack<Instructions>();
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        Navigate(original, target);
        TreeNode found = cloned;
        while(_toDo.Count > 0){
            Instructions action = _toDo.Pop();
            if (action == Instructions.Left)
                found = found.left;
            if (action == Instructions.Right)
                found = found.right;
        }
        return found;
    }
    
    private bool Navigate(TreeNode start, TreeNode target){
        if (start == target)
            return true;
        if (start == null)
            return false;
        
        if (Navigate(start.left, target)) {
            _toDo.Push(Instructions.Left);
            return true;
        }
            
        if (Navigate(start.right, target)){
            _toDo.Push(Instructions.Right);
            return true;
        }
        return false;
    }
}
