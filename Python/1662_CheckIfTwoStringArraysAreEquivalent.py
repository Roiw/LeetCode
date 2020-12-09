class Solution:
    def arrayStringsAreEqual(self, word1: List[str], word2: List[str]) -> bool:
        
        len1, len2 = len(word1), len(word2)
        i, j, a, b, t1, t2 = 0, 0, 0, 0, 0, 0
        while i < len1 and j < len(word2):
            s1, s2 = len(word1[i]), len(word2[j])
            
            while a < s1 and b < s2:
                if word1[i][a] != word2[j][b]:
                    return False
                a += 1
                b += 1
            
            if a == s1:
                t1 += a
                a = 0
                i += 1
                
            if b == s2:
                t2 += b
                b = 0
                j += 1
                
                
        return False if t1 != t2 else True
        