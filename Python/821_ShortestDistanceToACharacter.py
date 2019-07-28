class Solution:
    def shortestToChar(self, S: str, C: str) -> List[int]:
        result = list()
        count = 0;
        occurences = False
        for i in range(0, len(S)):
            if S[i] == C:
                if occurences == False:
                    result += list(range(count, -1, -1))
                else:
                    count += 1
                    for k in range(1, count+1, 1):
                        if k < count/2:
                            result.append(k)
                        else:
                            result.append(count-k)
                count = 0
                occurences = True
            else:
                count += 1
            
        if count > 0:
            result += list(range(1, count+1, 1))
        return result