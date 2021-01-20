class Solution:
    def removeDuplicates(self, S: str) -> str:        
        stck = []
        for w in S:
            if len(stck) > 0 and stck[-1] == w:
                while len(stck) > 0 and stck[-1] == w:
                    stck.pop()
            else:
                stck.append(w)
            
        return "".join(stck)
        