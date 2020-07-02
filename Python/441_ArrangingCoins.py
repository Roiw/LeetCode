class Solution:
    def arrangeCoins(self, n: int) -> int:
        i, count = 1, 0
        while n >= 0:
            n -= i
            if n < 0: break
            count += 1
            i += 1
        return count
        