class Solution:
    def singleNumber(self, nums: List[int]) -> List[int]:
        once = set()
        for x in nums:
            if x in once: once.remove(x)
            else: once.add(x)
        return once
        