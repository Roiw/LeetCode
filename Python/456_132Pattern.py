'''

    We create a stack of possible left candidates. 
    the left candidates are the minimum elements up to that value 0..element
    
    After that we go from the right picking candidates for the right.
    We keep a stack of those candidates, we pop from this stack as we go.
    

'''

class Solution:
    def find132pattern(self, nums: List[int]) -> bool:
        left, right = [],[]
        
        # Minimums from left to right
        for n in nums:
            left.append(min(left[-1], n) if left else n)
            
        # We move from right to left looking for candidates for the right
        # and checking if we got an answer.
        for i in range(len(nums) - 1, -1 , -1):
            
            # Check if we don't have a valid element anymore.
            while right and right[-1] <= left[i]:
                right.pop()
            
            # Check if we should update the right.
            if left[i] < nums[i]:
                # Check if we have a solution.
                if right and nums[i] > right[-1]:
                    return True
                
            right.append(nums[i])
            
        return False
        