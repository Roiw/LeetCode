class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        i = 0
        k = 0
        sortedList = list(nums)
        sortedList.sort()
        print(sortedList)
        while i < len(nums):
            while k < len(nums)-1:
                k += 1
                if sortedList[i] + sortedList[k] > target:
                    break
                elif sortedList[i] + sortedList[k] == target:
                    a = nums.index(sortedList[i])
                    nums[a] = sortedList[k] + 1
                    return [a, nums.index(sortedList[k])]
            i += 1
            k = i
          
        return 