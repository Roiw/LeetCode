class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        check = set()
        for n in nums:
            if n not in check :
                check.add(n)
            else:
                return True
        return False
            