# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

def DFS (p: TreeNode, q:TreeNode):
    if p.val != q.val:
        return False
    
    if p.left == None and p.right == None and q.right == None and q.left == None:
        return True
    
    b = True
    
    ## Check left
    if p.left != None and q.left != None:
         b = DFS(p.left, q.left)
    elif not (p.left == None and q.left == None):
        return False
    
    if b == False:
        return b
    
    ## Check right
    if p.right != None and q.right != None:
        b = DFS(p.right, q.right)
    elif not (p.right == None and q.right == None):
        return False
            
    return b

class Solution:
    def isSameTree(self, p: TreeNode, q: TreeNode) -> bool:
        if p == None and q != None:
            return False
        if p != None and q == None:
            return False
        if p == None and q == None:
            return True
        
        return DFS(p,q)
        
        