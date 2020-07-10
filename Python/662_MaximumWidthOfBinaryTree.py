# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    
    extremes = [[1,1]]
    widths = [1]
    def Dive(self, root: TreeNode, height:int, value: int):
        if height == len(self.widths): 
            self.extremes.append([value, value])
            self.widths.append(1)
        else: 
            if self.extremes[height][0] < value: 
                self.extremes[height][0] = value
            if self.extremes[height][1] > value: self.extremes[height][1] = value
            self.widths[height] = self.extremes[0] - self.extremes[1] + 1
            
        if root.left is None and root.right is None: return
        if root.left is not None: self.Dive(root.left, height + 1, value * 2)
        if root.right is not None: self.Dive(root.right, height + 1, value * 2 - 1)
        
    def widthOfBinaryTree(self, root: TreeNode) -> int:
        if root is None: return 0
        if root.left is None and root.right is None: return 1
        self.widths = [1]
        self.extremes = [1,1]
        
        # Starting DFS
        if root.left is not None: self.Dive(root.left, 1, 2)
        if root.right is not None: self.Dive(root.right, 1, 1)
            
        return max(self.widths)      
        