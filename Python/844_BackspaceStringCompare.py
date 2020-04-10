class Solution:
    def backspaceCompare(self, S: str, T: str) -> bool:
        sS = []
        sT = []
        for i in range(0, len(S)):
            if S[i] != '#':
                sS.append(S[i])
            elif len(sS) > 0:
                sS.pop()
        for i in range(0, len(T)):
            if T[i] != '#':
                sT.append(T[i])
            elif len(sT) > 0:
                sT.pop()
            
        if sS == sT:
            return True
        else:
            return False
        