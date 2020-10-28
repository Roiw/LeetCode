"""
    The plan:
    
        - Every digit we add n options
        - We go in a depth of K
"""

class Solution:
    def combine(self, n: int, k: int) -> List[List[int]]:
        
        ans = []
        
        def DFS(current_arr, index):
            if len(current_arr) == k:
                ans.append(list(current_arr))
                return
            
            for i in range(index, n + 1):
                current_arr.append(i)
                DFS(current_arr, i + 1)
                current_arr.pop()
        
        DFS([], 1)
        
        return ans
        