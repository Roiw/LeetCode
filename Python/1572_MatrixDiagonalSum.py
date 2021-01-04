class Solution:
    def diagonalSum(self, mat: List[List[int]]) -> int:
        total = 0
        for i in range(len(mat)):
            j = len(mat) - 1 - i
            total +=  mat[i][i] if i == j else mat[i][i] + mat[i][j]
        return total
        