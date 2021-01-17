# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sumRootToLeaf(self, root: TreeNode) -> int:
        numbers = []
        def findNumbers(node, curr):
            # Base case
            if node.left == None and node.right == None:
                numbers.append(int(curr + str(node.val), 2))
                return
            
            if node.left != None:
                findNumbers(node.left, curr + str(node.val))
            if node.right != None:
                findNumbers(node.right, curr + str(node.val))
        
        findNumbers(root, "")
        return sum(numbers)
        