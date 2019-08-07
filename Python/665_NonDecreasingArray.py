class Solution:
    def checkPossibility(self, nums: List[int]) -> bool:
         
        # O(N) Solution      
        foundAProblem = False
        for n in range(1, len(nums)):

            # Bad Case
            if (nums[n] < nums[n-1]):
                
                if foundAProblem:
                    return False
                
                if n == 1:
                    nums[0] = nums[n] # Doing fix B
                    
                elif n == len(nums) - 1:
                    return True
                    
                # Attempt Fix A
                elif nums[n+1] < nums[n-1]:
                    if nums[n+1] < nums[n-2] or nums[n-2] > nums[n]:
                        return False
                    nums[n-1] = nums[n]
                else:    
                    nums[n] = nums[n-1]
                
                foundAProblem = True
            
        return True