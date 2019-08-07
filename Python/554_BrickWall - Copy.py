# Return the amount of accourences of the same element in the list
def detectOccurences(frequency):
    dic = dict()
    maxOccurances = 0;
    for arr in frequency:
        for i in arr:
            if i in dic:
                dic[i] += 1
            else:
                dic[i] = 1 
            if dic[i] > maxOccurances:
                maxOccurances = dic[i]                
    
    return maxOccurances

class Solution:
        
    def leastBricks(self, wall: List[List[int]]) -> int:
        
        Frequency = list()
        for lst in wall:
            lastElem = 0
            array = list()
            for i in range(0, len(lst) -1, 1):
                array.append(lst[i] + lastElem)
                lastElem += lst[i]
            
            if len(array) > 0:
                Frequency.append(array)
        
        print (Frequency)
        maxGaps = detectOccurences(Frequency)   
        
        return len(wall) - maxGaps