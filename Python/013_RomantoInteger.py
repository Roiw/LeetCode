class Solution:
    def romanToInt(self, s: str) -> int:
        
        total = 0
        i = 0
        while i < len(s):
            
            # Check special cases..
            if i != len(s) - 1:
                if s[i] == 'I' and s[i+1] == 'V':
                    total = total + 4
                    i = i + 2
                    continue
                elif s[i] == 'I' and s[i+1] == 'X':
                    total = total + 9
                    i = i + 2
                    continue
                elif s[i] == 'X' and s[i+1] == 'L':
                    total = total + 40
                    i = i + 2
                    continue
                elif s[i] == 'X' and s[i+1] == 'C':
                    total = total + 90
                    i = i + 2
                    continue
                elif s[i] == 'C' and s[i+1] == 'D':
                    total = total + 400
                    i = i + 2
                    continue
                elif s[i] == 'C' and s[i+1] == 'M':
                    total = total + 900
                    i = i + 2
                    continue
            
            if s[i] == 'I':
                    total = total + 1
            elif s[i] == 'V':
                    total = total + 5
            elif s[i] == 'X':
                    total = total + 10
            elif s[i] == 'L':
                    total = total + 50
            elif s[i] == 'C':
                    total = total + 100
            elif s[i] == 'D':
                    total = total + 500
            elif s[i] == 'M':
                    total = total + 1000
            
            i = i +1
            
        return total
        
