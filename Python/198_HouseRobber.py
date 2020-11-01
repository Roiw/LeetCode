"""

    The Plan:
        - Case number of houses is: 0, 1, 2 we simple check and pick the best choice.
        - For 3 houses and forward, we must pick between:
            * All money made until house N-2 and the current house N
            * All money made until house N-1
        - The value picked is the maximum for house N
        - We must set the maximum for house N-1, which is the max between N-2 and N-1

    [1,2,3,1,6]
        > [1,2,4] we picked between 4 (1 + 3) or 2
        > [1,2,4,4] we picked between 3 (2 + 1) or 4
        > [1,2,4,4,5] we picked between 5 (4 + 1) or 4
        
    [2,1,1,2] example updating the max at N-1
        >[2,1,3]
        >[2,2,3,4]

"""

class Solution:
    def rob(self, nums: List[int]) -> int:
        # Base cases
        if len(nums) == 0: return 0
        if len(nums) == 1: return nums[0]
        if len(nums) == 2: return max(nums[0], nums[1])
        
        for i in range(2, len(nums)):
            nums[i] = max(nums[i-2] + nums[i], nums[i-1])
            nums[i-1] = max(nums[i-1], nums[i-2])
        
        return nums[-1]
        