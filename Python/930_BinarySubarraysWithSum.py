class Solution:
    def subarraysWithSum(self, nums: List[int], goal: int) -> int:
        sum = tail = 0
        count = 0
        for head in range(0, len(nums)):
            sum += nums[head]
            while (sum > goal and tail <= head):
                sum -= nums[tail]
                tail += 1
            count += (head - tail + 1) # number of subarrays
        return count
    
    def numSubarraysWithSum(self, nums: List[int], goal: int) -> int:
        return self.subarraysWithSum(nums, goal) - self.subarraysWithSum(nums, goal - 1) if goal > 0 else self.subarraysWithSum(nums, goal)
           
        