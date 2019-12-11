using System.Collections.Generic;
using TreeNode = DataStructures.Node;
namespace Algorithm.Sorting 
{
    public static class DFS
    {
        public static TreeNode Search(TreeNode root, int value)
        {
            // Found..
            if (root.Value == value)
                return root;

            // Base case..
            if (root.Left == null && root.Right == null)
                return null;

            TreeNode next = null;

            if (root.Left != null)
                next = Search(root.Left, value);
            
            if (next != null)
                return next;

            if (root.Right != null)
                next = Search(root.Right, value);
            
            return next;
        }
    }
}