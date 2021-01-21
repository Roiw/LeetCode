class Solution:
    def makeGood(self, s: str) -> str:
        word = []
        
        for letter in s:
            if len(word) > 0 and abs(ord(word[-1]) - ord(letter)) == 32:
                word.pop()
            else:
                word.append(letter)
                
        return "".join(word)
        