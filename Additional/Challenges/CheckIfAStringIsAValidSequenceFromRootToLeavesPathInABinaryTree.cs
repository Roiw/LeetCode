/*
Given a binary tree where each path going from the root to any leaf form a valid sequence, check if a given string is a valid sequence in such binary tree. 

We get the given string from the concatenation of an array of integers arr and the concatenation of all values of the nodes along a path results in a sequence in the given binary tree.

Example 1:
Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,0,1]
Output: true
Explanation: 
The path 0 -> 1 -> 0 -> 1 is a valid sequence (green color in the figure). 
Other valid sequences are: 
0 -> 1 -> 1 -> 0 
0 -> 0 -> 0

Example 2:
Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,0,1]
Output: false 
Explanation: The path 0 -> 0 -> 1 does not exist, therefore it is not even a sequence.
*/

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
    public bool IsValidSequence(TreeNode root, int[] arr) {    
        return Navigate(root, arr, 0);
    }
    
    private bool Navigate(TreeNode node, int[] arr, int depth){
        
        if (depth == arr.Length - 1 && arr[depth] == node.val &&
            node.left == null && node.right == null)
            return true;
        
        // Base case..
        if (depth == arr.Length || arr[depth] != node.val)
            return false;
        
        bool left = false, right = false;
        if (node.left != null)
            left = Navigate(node.left, arr, depth + 1);
        if (node.right != null && !left)
            right = Navigate(node.right, arr, depth + 1);
        
        if (right) return true;
        if (left) return true;
        
        return false;
    }
}
