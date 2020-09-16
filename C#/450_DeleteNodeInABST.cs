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

/*
    51
    
    1 - Find the node we must delete:
        Navigate the tree recursively. 
        Go left if current node is smaller than Target / Go right if opposite.
        
    2 - Remove the Node:
        If Target has left and righ child:  Father points to left child and insert right on new node's right.
        If Target has left child:           Make father point to the left child of Target.
        If Target has right child:          Make father point to right child of Target
        
    3 - Insert Node:
        Navigate the tree recusively:  
            if current is bigger than new node:
                if current.left == null? newNode 
                otherwise navigate to current.left
            if current is smaller than new node:
                if current.right == null? newNode 
                otherwise navigate to current.right;
*/

public class Solution {
    
    public void Insert(TreeNode root, TreeNode newNode) {
        if (root.left == null && root.val > newNode.val){ root.left = newNode; return;}
        if (root.right == null && root.val < newNode.val){ root.right = newNode; return;}
        if (root.val > newNode.val) Insert(root.left, newNode);
        else Insert(root.right, newNode);
    }
    
    public TreeNode FindNode(TreeNode root, int target) {
        if (root == null) return null;
        if (root.left != null && root.left.val == target) return root;
        if (root.right != null && root.right.val == target) return root;
            
        if (root.left != null && target < root.val)
            return FindNode(root.left, target);
        else
            return FindNode(root.right, target);      
    }
    
    public TreeNode DeleteNode(TreeNode root, int key) {
        // Edge case empty.
        if (root == null) return null;
        
        // Edge case remove base.
        if (root.val == key) {
            if (root.left != null && root.right != null) {
                root.val = root.left.val;
                if (root.left.right != null) Insert(root, root.left.right );  
                root.left = root.left.left;
            }
            else if (root.left != null || root.right != null) 
                root = root.left == null? root.right : root.left;
            else
                root = null;
            return root;
        }
        
        // Normal removal
        TreeNode rtn = new TreeNode(0, root, null);
        TreeNode father = FindNode(root, key);
        if (father == null) return rtn.left; // Could not find key to delete.
        
        bool isLeft = father.left != null && father.left.val == key? true: false;
        TreeNode toDelete = isLeft? father.left: father.right;
        
        // Delete the key
        TreeNode newNode = null;
        if (toDelete.left != null && toDelete.right != null) {
            newNode = toDelete.left;
            Insert(newNode, toDelete.right);          
        }
        else if (toDelete.left != null || toDelete.right != null) {
            newNode = toDelete.left == null? toDelete.right : toDelete.left;
        }
        
        if (isLeft)
            father.left = newNode;
        else
            father.right = newNode;
        
        return rtn.left;
    }
}
