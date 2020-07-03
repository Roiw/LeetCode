# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def levelOrderBottom(self, root: TreeNode) -> List[List[int]]:
        if root is None: return []
        q = deque()
        q.append([0,root])
        ans = []
        while q:
            h,n = q.popleft()
            if len(ans) <= h: ans.append([])
            ans[h].append(n.val)           
            if n.left != None: q.append([h + 1, n.left])
            if n.right != None: q.append([h + 1, n.right])
            
        return reversed(ans)
    
    