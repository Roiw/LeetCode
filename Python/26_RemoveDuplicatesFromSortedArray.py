class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0

        count = 1
        i = 1          
        while i < len(nums):
            if (nums[count-1] == nums[i]):
                for n in range(i+1, len(nums)):
                    if nums[count-1] != nums[n]:
                        nums[count] = nums[n]
                        i = n - 1
                        count  += 1
                        break
            else:
                count  += 1
            i += 1
                
        return count