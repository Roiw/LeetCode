class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        elems = {}
        for i, n in enumerate(nums):
            if n in elems and abs(i - elems[n]) <= k:
                return True
            elems[n] = i
        return False
                