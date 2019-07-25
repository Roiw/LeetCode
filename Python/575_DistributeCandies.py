class Solution(object):
    def distributeCandies(self, candies):
             
        sisterCandies = set()
        size = len(candies)/2
        
        for i in candies:
            sisterCandies.add(i)
            
            if len(sisterCandies) == size:
                # Case the length of the set is half the length of the array we finished.
                return len(sisterCandies)
            
        return len(sisterCandies)