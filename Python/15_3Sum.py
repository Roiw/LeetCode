class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        amounts = collections.Counter(nums)
        nums = sorted(amounts)
        ans = []
        for i, num in enumerate(nums):
            if num == 0:
                if amounts[num] > 2:
                    ans.append([0,0,0])
            elif amounts[num] > 1 and -2 * num in amounts:
                ans.append([num, num, - 2 * num])
            
            if num < 0:  #less than zero because we are moving on a sorted array
                opposite = - num
                left = bisect_left(nums, opposite - nums[-1], i + 1)
                right = bisect_right(nums, opposite / 2, left)
                for a in nums[left:right]:
                    b = opposite - a
                    if b in amounts and a != b:
                        ans.append([num, a, b])
            
        return ans
        