class Solution:
    def freqAlphabets(self, s: str) -> str:
        ans = ""
        fixed = 0
        for i in range(len(s) - 1, -1, -1):
            if fixed > 0:
                fixed -= 1
                continue
            
            if (s[i]) == '#':
                temp = s[i-2] + s[i - 1]
                ans = chr(96 + int(temp)) + ans
                fixed = 2
            else:
                ans = chr(96 + int(s[i])) + ans
        
        return ans
        