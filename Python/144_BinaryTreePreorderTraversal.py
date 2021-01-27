# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def preorderTraversal(self, root: TreeNode) -> List[int]:
        
        def traverse(node, ans):
            if node == None:
                return ans
            
            ans.append(node.val)
            ans = traverse(node.left, ans)
            return traverse(node.right, ans)
        
        return traverse(root, [])
        