class Solution:
    def checkRecord(self, s: str) -> bool:
        countA = 0
        countL = 0
        for c in s:
            if c == 'A':
                countA += 1
                if countA > 1:
                    return False 
                countL = 0
            elif c == 'L':
                countL += 1
                if countL > 2:
                    return False
            else:
                countL = 0      
        return True