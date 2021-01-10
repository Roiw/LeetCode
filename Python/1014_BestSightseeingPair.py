'''

    Two pointer:
    
    p0 is always the leftmost pointer, and we try to maximize it.
    p1 is always to the right of p0 and we use it to calculate.
    
    The idea is that to maximize p0 we must take in consideration its relative distance to p1
    That is why we check n + p1 >= A[p0] + p0 and not just n >= A[p0].

'''

class Solution:
    def maxScoreSightseeingPair(self, A: List[int]) -> int:
        p0, maximum = 0, -1
        
        for p1 in range(1, len(A)):
            n = A[p1]
            maximum = max(maximum, A[p0] + n - (p1 - p0) )
            p0 = p1 if n + p1 >= A[p0] + p0 else p0
        
        return maximum
            