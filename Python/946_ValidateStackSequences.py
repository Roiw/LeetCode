class Solution:
    def validateStackSequences(self, pushed: List[int], popped: List[int]) -> bool:
        if len(pushed) != len(popped):
            return False
        elif len(pushed) == 0 and len(popped) == 0:
            return True
        
        aux = []
        p1, p2 = 0, 0
        while p1 < len(pushed) and p2 < len(popped):
            lPu, lPo = len(pushed), len(popped)
            if p1 < lPu and p2 < lPo and pushed[p1] == popped[p2]:
                p1 += 1
                p2 += 1
            elif len(aux) > 0 and p2 < lPo and aux[-1] == popped[p2]:
                aux.pop()
                p2 += 1
            elif p1 < lPu:
                aux.append(pushed[p1])
                p1 += 1
        
        while p2 < len(popped):
            if aux[-1] == popped[p2]:
                aux.pop()
                p2 += 1
            else:
                return False
        
        return True
