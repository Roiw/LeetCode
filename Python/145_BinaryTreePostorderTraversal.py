# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def postorderTraversal(self, root: TreeNode) -> List[int]:
        if root == None:
            return []
        
        traversed = self.postorderTraversal(root.left)
        right = self.postorderTraversal(root.right)       
        for e in right:
            traversed.append(e)
            
        traversed.append(root.val)
        return traversed
        