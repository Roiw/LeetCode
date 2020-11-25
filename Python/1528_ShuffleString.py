class Solution:
    def restoreString(self, s: str, indices: List[int]) -> str:
        newString = ['a'] * len(s)
        for i, n in enumerate(indices):
            newString[n] = s[i]
        return ''.join(newString)
        