using System.Collections.Generic;
using TreeNode = DataStructures.Node;
namespace Algorithm.Sorting 
{
    public static class BFS
    {
        public static TreeNode Search(TreeNode root, int value)
        {
            Queue<TreeNode> toSearch = new Queue<TreeNode>();
            toSearch.Enqueue(root);
            while (toSearch.Count > 0) 
            {
                TreeNode current = toSearch.Dequeue();
                if (current.Value == value)
                    return current;
                else
                {
                    if (current.Left != null)
                        toSearch.Enqueue(current.Left);
                    if (current.Right != null)
                        toSearch.Enqueue(current.Right);
                }
            }
            return null;
        }
    }
}