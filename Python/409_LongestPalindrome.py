class Solution:
    def longestPalindrome(self, s: str) -> int:
        longest = 0
        seen = set()
        for c in s:
            if c in seen:
                seen.remove(c)
                longest += 2
            else:
                seen.add(c)
        
        if len(seen) > 0:
            longest +=1
        return longest
        
        