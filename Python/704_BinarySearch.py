class Solution:
    currentIndex = 0
    def search(self, nums: List[int], target: int) -> int:
        
        # Base case I
        if len(nums) == 0: # End of array
            return -1        
        halfIndex = math.floor(len(nums)/2)     
        
        # Base case II
        if nums[halfIndex] == target: # Found element
            return self.currentIndex + halfIndex
        
        # if smaller go left       
        if nums[halfIndex] > target:
            result = self.search(nums[:halfIndex], target) 
        else:
            self.currentIndex += halfIndex +1
            result = self.search(nums[halfIndex +1:], target) 
        return result