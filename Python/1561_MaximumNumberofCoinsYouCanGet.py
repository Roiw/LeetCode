'''
The Plan O(N)

- Sort the piles list.
- For every set of 3 sum the middle pile size.

'''
class Solution:
    def maxCoins(self, piles: List[int]) -> int:
        piles.sort()
        size = len(piles)
        total = 0
        j = size
        for i in range(size // 3):
            j -= 2
            total += piles[j]
            
        return total
        
        