class Solution:
    def addBinary(self, a: str, b: str) -> str:
        #31
        i = len(a) - 1
        j = len(b) - 1
        ans = []
        carry = False     
        while i >= 0 or j >= 0 :
            aa = True if i >= 0 and a[i] == '1' else False
            bb = True if j >= 0 and b[j] == '1' else False
            ans.append( "1" if aa ^ bb ^ carry else "0")
            carry = aa and bb or bb and carry or aa and carry
            i -= 1
            j -= 1
        if carry: ans.append('1')
        ans.reverse()
        return ''.join(str(e) for e in ans)
            