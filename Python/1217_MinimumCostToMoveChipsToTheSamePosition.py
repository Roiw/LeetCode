class Solution:
    def minCostToMoveChips(self, position: List[int]) -> int:
        evens, odds = 0, 0
        for i in position:
            if i % 2 == 0:
                evens += 1
            else:
                odds += 1
        return min(odds,evens)
        