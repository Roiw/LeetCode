class Solution:
    def checkIfCanBreak(self, s1: str, s2: str) -> bool:
        sort1 = sorted(s1)
        sort2 = sorted(s2)
        
        check1 = True
        check2 = True
        
        for i in range(len(sort1)):
            if sort2[i] < sort1[i]:
                check1 = False
            if sort1[i] < sort2[i]:
                check2 = False
            
        return  check1 or check2
        