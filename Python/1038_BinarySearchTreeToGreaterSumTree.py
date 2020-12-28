# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def bstToGst(self, root: TreeNode) -> TreeNode:  
        
        def DFS(r, offset):
                          
            right = DFS(r.right, offset) if r.right != None else offset
            r.val += right        
            left = DFS(r.left, r.val) if r.left != None else 0

            return r.val + (left - r.val) if r.val <= left else r.val
        
        DFS(root, 0)
        
        return root
        