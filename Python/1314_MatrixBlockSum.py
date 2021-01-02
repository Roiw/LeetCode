'''
    Dynamic Programming
        - Create a matrix (mem) that holds the values of all the sums from M[0][0] to M[X][Y]
        - Retrieve from mem the maximum sum for the range going from (0,0) to (i + k,j + K)
        - Remove range from (0,0) to (i - K, j - K), when necessary, somtimes K covers the whole matrix.
        - Add back any subtracted contrubution that was removed twice.
    
    If it's hard to visualize, try drawing the matrices on paper; Original matrix (mat), sum matrix (mem) and result matrix (answer).
    Imagine how you would reduce sum matrix to get the answer you need.
'''
class Solution:
    def matrixBlockSum(self, mat: List[List[int]], K: int) -> List[List[int]]:
        
        # Memory is a matrix where M[X][Y] are the sum of all numbers from M[0][0] to M[X][Y] 
        mem = [[0 for i in range(len(mat[0]))] for j in range(len(mat))]
        
        # Fill memory matrix
        for r in range(len(mat)):
            for c in range(len(mat[r])):
                left = 0 if c - 1 < 0 else mem[r][c - 1]
                down = 0 if r - 1 < 0 else mem[r-1][c]
                prev = 0 if r - 1 < 0 or c - 1 < 0 else mem[r-1][c-1]
                mem[r][c] = mat[r][c] + left + down - prev
        
        
        # The sum at an element is it's value minus p
        def blockSum(i, j, k):
            # Max index of row(MR) and column (MC)
            MR = len(mat)-1 if i + k >= len(mat) else i + k
            MC = len(mat[i]) - 1 if j + k >= len(mat[i]) else j + k
            
            # If we want to take into account only a submatrix we must subtract:
            # The contrubution sum from the top and the contribution sum from the left.
            top = 0 if i - k - 1 < 0 else mem[i - k - 1][MC]
            left = 0 if j - k - 1 < 0 else mem[MR][j - k - 1]
            
            # In case we subtracted contributions from TOP and LEFT 
            # we certainly subtracted twice the contribution from their intesection.
            intersect = mem[i - k - 1][j - k - 1] if top != 0 and left != 0 else 0
            
            return mem[MR][MC] - top - left + intersect
            
            
        
        answer = [[0 for i in range(len(mat[0]))] for j in range(len(mat))]
        
        for i in range( len(mat) ):
            for j in range(len(mat[i])):
                answer[i][j] = blockSum(i, j, K)
        
        return answer
        