'''

    Generating all combinations (backtracking + memoization):
        - For every position on the new string you can place the last number or a smaller number.  
    
'''

class Solution:    
    
    def countVowelStrings(self, n: int) -> int:
        if n == 0: return 0
        memo = dict()
        
        def countStringSubproblem(n, last):
            if n == 1: 
                return last
            
        
            if (n, last) in memo:
                return memo[(n, last)]
            
            total = 0
            for j in range(last):
                total += countStringSubproblem(n - 1, last - j)
            
            memo[(n, last)] = total
            return total
        
        return countStringSubproblem(n, 5)
            