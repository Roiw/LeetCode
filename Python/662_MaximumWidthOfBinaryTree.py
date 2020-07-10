# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
class Solution:
    def widthOfBinaryTree(self, root: TreeNode) -> int:
        if root is None: return 0
        self.maxWidth = 1
        self.extremes = [[1,1]]
        
        def Dive(root: TreeNode, height:int, value: int):
            if height == len(self.extremes): self.extremes.append([value, value])
            else: 
                self.extremes[height][0] = max(self.extremes[height][0], value)
                self.extremes[height][1] = min(self.extremes[height][1], value)
                width = self.extremes[height][0] - self.extremes[height][1] + 1
                self.maxWidth = max(self.maxWidth, width)

            if root.left is not None: Dive(root.left, height + 1, value * 2)
            if root.right is not None: Dive(root.right, height + 1, value * 2 - 1)
        
        # Starting DFS
        if root.left is not None: Dive(root.left, 1, 2)
        if root.right is not None: Dive(root.right, 1, 1)
            
        return self.maxWidth  
        