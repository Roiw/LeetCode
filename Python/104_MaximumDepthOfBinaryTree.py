# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def maxDepth(self, root: TreeNode) -> int:
        if root == None: return 0
        
        def DFS(height, node):
            if node == None:
                return height
            return max(DFS(height, node.left), DFS(height, node.right)) + 1
        
        return max(DFS(0, root.left), DFS(0, root.right)) + 1
        