'''
The Plan

- Two similar piles and one lower pile.
- Sort piles get top two and last. The second from the top we add to total

'''
class Solution:
    def maxCoins(self, piles: List[int]) -> int:
        piles.sort()
        deq = deque()
        
        # Creates a deque
        for i in piles:
            deq.append(i)
            
        # Calulates
        total = 0
        while len(deq) > 0:
            deq.pop()
            total += deq.pop()
            deq.popleft()
        return total
        