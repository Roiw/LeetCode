class Solution:
    def smallestRangeI(self, A: List[int], K: int) -> int:
        # 42
        A.sort()
        minimum, maximum = A[0], A[len(A) - 1]
        diff = maximum - minimum
        
        if diff <= K * 2: return 0
        else: return diff - K * 2
        