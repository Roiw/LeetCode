public class NumMatrix {
    
    public int[][] m;

    public NumMatrix(int[][] matrix) {
        m = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int sum = 0;
        for (int i = col1; i <= col2; i++){
            for (int j = row1; j <= row2; j++)
                sum += m[j][i];
        }
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
 