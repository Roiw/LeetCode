'''

    Dynamic Programming
    
    1 - Optimal Substructure.
    2 - Overlapping Subproblems.
    
'''

class Solution:
    def fib(self, n: int) -> int:
        if n == 0: return 0
        if n == 1 or n == 2: return 1
           
        A, B = 1, 1
        
        for i in (range(n - 2)):
            AUX = B
            B += A
            A = AUX
            
        return B
        