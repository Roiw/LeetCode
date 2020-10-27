"""
    Backtracking
    - Add initial case (full word) as a base case, line 47
    - Slice on every index from 1 to len-1
    - If PartA and PartB are palindrome append to the list.
    - Continue backtracking only if PartA is palindrome. It becomes an offset now.
    
"""

class Solution:
    def partition(self, s: str) -> List[List[str]]:
        
        ans = []
        
        def isPalindrome(word:str):
            p0, p1 = 0, len(word) - 1
            while p0 < p1:
                if word[p0] != word[p1]:
                    return False
                p0 += 1
                p1 -= 1
            return True
        
        
        def backtrack(word, index, offset):
            
            for i in range(index,len(word)):
                partA = word[:i]
                partB = word[i:]
                
                is_A_Palindrome = isPalindrome(partA)
                is_B_Palindrome = isPalindrome(partB)
                
                if is_A_Palindrome and is_B_Palindrome:
                    ans.append(offset +  [partA, partB])
                    
                if is_A_Palindrome:
                    backtrack(partB, 1, offset +  [partA])
                

                
        
        if isPalindrome(s):
            ans.append([s])
            
        backtrack(s, 1, [])
        return ans
            
            
        