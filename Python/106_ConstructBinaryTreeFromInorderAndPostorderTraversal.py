# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def buildTree(self, inorder: List[int], postorder: List[int]) -> TreeNode:
        if len(inorder) == 0: return None
        inOrderDict = {order: i for i, order in enumerate(inorder)}
        
        # Find the root.
        root, divisor, toRemove  = TreeNode(), 0, len(postorder)-1
        while toRemove >= 0:
            if postorder[toRemove] in inOrderDict:
                divisor = inOrderDict[postorder[toRemove]]
                root.val = postorder[toRemove]
                break
            toRemove -= 1
            
        reducedPost = postorder[:-1]
        root.left = self.buildTree(inorder[:divisor], reducedPost)
        root.right = self.buildTree(inorder[divisor+1:], reducedPost)
        return root
                
## Solution 2 -> Drastically increase memory usage 97% better than other Python3 submissions
class Solution:
    postorder = []
    inorder = []
    def treeBuilder(self, inOrderLowerRange:int, inOrderHigherRange:int):
        if inOrderLowerRange >= inOrderHigherRange: return None        
        root, rootIndex, divisor = TreeNode(), len(self.postorder)-1, -1        
        while rootIndex >= 0:   
            possibleRoot = self.postorder[rootIndex]
            for x in range(inOrderLowerRange, inOrderHigherRange):
                if self.inorder[x] == possibleRoot:
                    divisor = x
                    root.val = possibleRoot
                    self.postorder.pop(rootIndex)
                    break
            if divisor != -1: break
            rootIndex -= 1
        
        root.left = self.treeBuilder(inOrderLowerRange, divisor)
        root.right = self.treeBuilder(divisor + 1, inOrderHigherRange)
        return root
        
    def buildTree(self, inorder: List[int], postorder: List[int]) -> TreeNode:        
        self.postorder = postorder
        self.inorder = inorder
        return self.treeBuilder(0, len(inorder))              
                