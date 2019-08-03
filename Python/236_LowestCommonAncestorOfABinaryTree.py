# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    
    StackParents_P = list()
    StackParents_Q = list() 
    stackTransition = list()
    
    def DFS (self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode'):
        
        self.stackTransition.append(root)
        
        if (root == p):
            self.StackParents_P = list(self.stackTransition)
        elif (root == q):
            self.StackParents_Q = list(self.stackTransition)
        
        if (root.left != None):
            self.DFS(root.left, p, q)
        if (root.right != None):
            self.DFS(root.right, p, q)
        
        self.stackTransition.pop()                   
        return
        
        
    
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        
        # DFS keeping track of the parents.
        # Once we find a node we save the list of parents the node has.
        # Compare the lists of parents 
        self.DFS(root,p,q)      
        rtn = root
               
        
        for k in range(0, min(len(self.StackParents_P), len(self. StackParents_Q) ) ):
            if (self.StackParents_P[k] != self.StackParents_Q[k]):
                return rtn
            else:
                rtn = self.StackParents_P[k]
        return rtn