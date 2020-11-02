"""
    The plan:
        - Create a table to keep track of the length of common substrings.
        
                a   b   c   d   e
            0   0   0   0   0   0
        a   0   1   1   1   1   1
        c   0   1   1   2   2   2
        e   0   1   1   2   2   3
        
        Rules to fill the matrix:
            * When characters match (top left) the cell value is the northwest diagonal + 1
            * When characters don't match the cell value is the max between north and west.
"""


class Solution:
    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        table = [[0 for j in range(len(text2) + 1)] for i in range(len(text1) + 1)]
        for i in range(1, len(text1) + 1):
            for j in range(1, len(text2) + 1):
                if text1[i-1] == text2[j-1]:
                    table[i][j] = table[i-1][j-1] + 1
                else:
                    table[i][j] = max(table[i-1][j], table[i][j-1])
                    
        return table[len(text1)][len(text2)]
        