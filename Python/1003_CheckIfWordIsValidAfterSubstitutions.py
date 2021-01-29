class Solution:
    def isValid(self, s: str) -> bool:
        stck = []
        for c in s:
            if len(stck) < 2:
                stck.append(c)
                continue
            if c == 'c' and stck[-1] == 'b'and stck[-2] == 'a':
                stck.pop()
                stck.pop()
            else:
                stck.append(c)
        
        return True if len(stck) == 0 else False
                