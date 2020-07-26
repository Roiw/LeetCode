class Solution:
    def ModBinSearch(self, nums: List[int], start: int, end: int) -> int :    
        rValue = nums[end] if end < len(nums) - 1 else inf
        lValue = nums[start] if end < len(nums) - 1 else inf
        if (start > end): return min(nums[0], lValue, rValue)
        mid = start + (end - start) // 2
        if (nums[0] > nums[mid]): return self.ModBinSearch(nums, start, mid - 1)
        elif (nums[0] < nums[mid]): return self.ModBinSearch(nums, mid + 1, end)
        else: 
            right = self.ModBinSearch(nums, mid + 1, end)
            left = self.ModBinSearch(nums, start, mid - 1)
            return min(left, right)
        
    def findMin(self, nums: List[int]) -> int:
        return self.ModBinSearch(nums, 0, len(nums) - 1 )
        