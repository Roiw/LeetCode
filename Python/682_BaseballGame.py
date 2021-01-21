class Solution:
    def calPoints(self, ops: List[str]) -> int:
        stck = []
        total = 0
        for c in ops:
            if c == "+":
                n = stck[-1] + stck[-2]
                total += n
                stck.append(n)
                
            elif c == "D":
                n = stck[-1] * 2
                stck.append(n)
                total += n
                
            elif c == "C":
                n = stck.pop()
                total -= n
                
            else:
                n = (int(c))
                stck.append(n)
                total += n
        return total
        