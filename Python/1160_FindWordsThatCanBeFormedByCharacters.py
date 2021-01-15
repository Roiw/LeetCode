from collections import Counter
class Solution:
    def countCharacters(self, words: List[str], chars: str) -> int:
        lens = 0
        goodChars = Counter(chars)
        for word in words:
            wChars = Counter(word)
            increment = len(word)
            for c in wChars:
                if c not in goodChars or wChars[c] > goodChars[c]:
                    increment = 0
                    break
            lens += increment
        return lens
                    