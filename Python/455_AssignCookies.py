class Solution:
    def findContentChildren(self, g: List[int], s: List[int]) -> int:
        g.sort()
        s.)
        k, c, happyKids = 0,0,0
        while k < len(g) and c < len(s):
            if g[k] <= s[c]:
                k = k + 1
                happyKids = happyKids + 1
            c = c + 1
        return happyKids
        
