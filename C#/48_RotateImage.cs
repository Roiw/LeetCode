// No extra memory.
// We only 'know' how to solve the outmost values of the matrix.
// We then start heading towards the nucleus of the matrix (a 2x2 matrix), which is our basecase.
// Then we rotate from inside out.

public class Solution {
    public void Rotate(int[][] matrix) {
        Rotate(matrix, matrix.Length, 0);        
    }
    
    // A recursive approach..
    private void Rotate(int[][] matrix, int len, int start){
        
        if (len > 3) 
            Rotate(matrix, len - 2, start + 1);
        
        for (int i = 0; i < len-1; i++){
            int save1 = matrix[start + i][start + len - 1];
            int save2 = matrix[start + len - 1][start + len - 1 - i];
            int save3 = matrix[start + len - 1 - i][start];
            
            // Rotate..
            matrix[start + i][start + len - 1] = matrix[start][start + i];
            matrix[start + len - 1][start + len - 1 - i] = save1;
            matrix[start + len - 1 - i][start] = save2;
            matrix[start][start + i] = save3;
        }
    }
}
