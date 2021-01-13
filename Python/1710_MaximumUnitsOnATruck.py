# O(N2)
class Solution:
    def maximumUnits(self, boxTypes: List[List[int]], truckSize: int) -> int:
        # O(N)
        def findBiggest():
            biggest = [0, 0]
            index = -1
            for i, arr in enumerate(boxTypes):
                if arr[1] > biggest[1]:
                    biggest = arr
                    index = i
            boxTypes.pop(index)
            return biggest
        
        totalUnits = 0
        while truckSize > 0 and len(boxTypes) > 0:
            biggest = findBiggest()
            placed = biggest[0] if truckSize >= biggest[0] else truckSize
            truckSize -= placed
            totalUnits += placed * biggest[1]
        
        return totalUnits

# O(NlogN)
class Solution:
    def maximumUnits(self, boxTypes: List[List[int]], truckSize: int) -> int:
       
        # Sort based on the element on index 1 of every array.
        boxTypes.sort(key = lambda elem:elem[1], reverse = True)
        
        totalUnits = 0
        for amount, units in boxTypes:
            totalUnits += min(amount, truckSize) * units
            truckSize -= amount
            if truckSize <= 0: break

        return totalUnits