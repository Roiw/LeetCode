class Solution:
           
    def findRadius(self, houses: List[int], heaters: List[int]) -> int:
        # I want to find the longest, minimum, distance from heater to house        
        
        # For each house determine the smallest distance to a heater.
        heaters.sort()
        houses.sort()
        
        biggest = 0           
        hEvaluated = dict()
        
        lastHeater = heaters[0]
        lastHeaterIndex = 0
        heaterRange = 0
        auxIndex = 0
        
        for h in houses:
            if h in hEvaluated:
                continue
            if (abs(h - lastHeater) < abs(h - heaters[0])):
                # Start from this heater:
                heaterRange = lastHeaterIndex    
                auxIndex = lastHeaterIndex    
            else:
                # Start from beginning
                auxIndex = 0
                heaterRange = 0
            
            for e in range(heaterRange, len(heaters)):
                hEvaluated[h] = abs(h - lastHeater)
                
                if abs(h - heaters[e]) > abs(h - lastHeater):              
                    break
                else:
                    lastHeater = heaters[e]
                    lastHeaterIndex = auxIndex
                    hEvaluated[h] = abs(h - heaters[e])
                    
                auxIndex += 1
            
            if (biggest <  hEvaluated[h]):
                biggest = hEvaluated[h]
                        
        
        return biggest
                
                
                
        