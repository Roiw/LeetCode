public class Solution {
    public int NumSpecial(int[][] mat) {
        
        /*
            Sum every element on each row and column
            
            r = [1, 1, 1]
            c = [2, 0, 1]
        */
        
        int[] row = new int[mat.Length];
        int[] col = new int[mat[0].Length];
        
        for (int i = 0; i < mat.Length; i++){
            int r = 0;
            for (int j = 0; j < mat[i].Length; j++) {
                r += mat[i][j];
                col[j] += mat[i][j];
            }
            row[i] = r;
        }
        
        int count = 0;
        for (int i = 0; i < mat.Length; i++){
            for (int j = 0; j < mat[i].Length; j++) {
                if (mat[i][j] == 1)
                    count += row[i] == 1 && col[j] == 1? 1: 0;   
            }
        }
        return count;
    }
}