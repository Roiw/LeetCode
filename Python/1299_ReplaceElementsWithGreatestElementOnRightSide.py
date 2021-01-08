class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:
        nArr = deque([-1])
        
        for i in range(len(arr) - 1, 0, -1):
            val = max(arr[i], nArr[0]) 
            nArr.appendleft(val)
        
        return list(nArr)
