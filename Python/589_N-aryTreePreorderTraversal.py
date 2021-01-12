"""
# Definition for a Node.
class Node:
    def __init__(self, val=None, children=None):
        self.val = val
        self.children = children
"""

class Solution:
    def preorder(self, root: 'Node') -> List[int]:
        lst = []
        def DFS(node):
            if node == None:
                return
            
            lst.append(node.val)
            for c in node.children:
                DFS(c)
                
        DFS(root)
        return lst
    