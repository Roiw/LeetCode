class Solution:
    def nthUglyNumber(self, n: int) -> int:
        if n == 0: return 0
        i2, i3, i5 = 0,0,0
        ans = [1]
        for i in range(1,n):
            a = ans[i2] * 2
            b = ans[i3] * 3
            c = ans[i5] * 5
            
            m = min(a, b, c)
            
            i2 = i2 + 1 if m == a else i2
            i3 = i3 + 1 if m == b else i3
            i5 = i5 + 1 if m == c else i5
            ans.append(m)
        return ans[-1]
        