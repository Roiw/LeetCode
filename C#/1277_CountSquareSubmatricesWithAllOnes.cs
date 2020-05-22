public class Solution {
    public int CountSquares(int[][] matrix) {
        int count = 0;
        int [][] m = new int[matrix.Length + 1][];
        for (int i = 0; i < m.Length; i++){ m[i] = new int[matrix[0].Length + 1];}      
        for (int i  = 0; i < matrix.Length; i++){         
            for (int j = 0; j < matrix[i].Length; j++) { 
                if (matrix[i][j] == 1){
                    int amount = Math.Min(m[i][j+1], m[i+1][j]);
                    m[i+1][j+1] = 1 + Math.Min(amount,  m[i][j]);
                    count += m[i+1][j+1];
                }
            }
        }
        return count;
    }
}
