# O(N3)
class Solution:
    def countGoodTriplets(self, arr: List[int], a: int, b: int, c: int) -> int:
        good = 0
        for i in range(len(arr)):
            for j in range(i + 1, len(arr)):
                for k in range(j + 1, len(arr)):   
                    n, m, o = arr[i], arr[j], arr[k] 
                    if abs(n - m) <= a and abs(m - o) <= b and abs(n - o) <= c:
                        good += 1
                    
        return good
        