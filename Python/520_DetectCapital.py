class Solution:
    def detectCapitalUse(self, word: str) -> bool:
        upperCount, lowerCount = 0, 0
        for letter in word:
            if letter > 'Z': lowerCount += 1
            else: upperCount += 1
            if lowerCount > 0 and upperCount > 1:
                return False
            elif lowerCount > 0 and letter <= 'Z':
                return False
        return True
        