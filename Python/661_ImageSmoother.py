def calculateValue(index, M):
    total = 0
    amount = 0
    maxColumn = len(M[index[0]])-1
    maxRow = len(M)-1
    
    if index[0] > 0:
        total += M[index[0]-1][index[1]] # R-1
        amount += 1
    if index[0] < maxRow:
        total += M[index[0]+1][index[1]] # R+1 
        amount += 1

    if index[1] > 0:
        total += M[index[0]][index[1] - 1] # C-1
        amount += 1
    if index[1] < maxColumn:
        total += M[index[0]][index[1] + 1] # C+1
        amount += 1
    
    if index[0] > 0 and index[1] > 0:      # R-1 C-1
        total += M[index[0]-1][index[1]-1]
        amount += 1
    
    if index[0] < maxRow and  index[1] < maxColumn: # R+1 C+1
        total += M[index[0]+1][index[1]+1]
        amount += 1
    
    if index[0] > 0 and index[1] < maxColumn: # R-1 C+1
        total += M[index[0]-1][index[1]+1]
        amount += 1
    
    if index[0] < maxRow and index[1] > 0:         # R+1 C-1
        total += M[index[0]+1][index[1]-1]
        amount += 1  
        
    total += M[index[0]][index[1]]
    amount += 1

    return math.floor(total/amount)
        
    
class Solution:
    def imageSmoother(self, M: List[List[int]]) -> List[List[int]]:
        
        N = list()
        for r in range(0, len(M)):
            nList = list()
            for c in range(0, len(M[r])):
                nList.append(calculateValue([r,c],M))                    
            N.append(nList)   
        return N
                
           