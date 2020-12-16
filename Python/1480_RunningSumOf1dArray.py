class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        runSum = []
        for i,n in enumerate(nums):
            elem = runSum[i-1] + n if i > 0 else n
            runSum.append(elem)
            
        return runSum
        