class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        letters = dict()
        for letter in s:
            if letter in letters:
                letters[letter] += 1
            else:
                letters[letter] = 1
        
        for letter in t:
            if letter not in letters:
                return False
            letters[letter] -= 1
            if letters[letter] == 0:
                letters.pop(letter)
        
        if len(letters) > 0:
            return False
        
        return True
