# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
        
    def isSameTree(self, p: TreeNode, q: TreeNode) -> bool:
        if p == None and q == None: return True
        elif p == None and q != None or p != None and q == None: return False
        elif p.val != q.val: return False
        
        val = self.isSameTree(p.left,q.left)
        val = val and self.isSameTree(p.right,q.right)
        return vals