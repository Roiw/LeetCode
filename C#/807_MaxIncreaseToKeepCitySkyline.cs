public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) { 
        int [] T = new int[grid.Length];
        int [] L = new int[grid.Length];
        
        for (int i = 0; i < grid.Length; i ++) {
            for (int j = 0; j < grid.Length; j ++) {
                if ( grid[i][j] > L[i])
                    L[i] = grid[i][j];
                if ( grid[i][j] > T[j])
                    T[j] = grid[i][j];
            }
        }
        
        int sum = 0;
        
        for (int i = 0; i < grid.Length; i ++) {
            for (int j = 0; j < grid.Length; j ++) {
                int k = Math.Min(T[j], L[i]);
                sum += k - grid[i][j];
            }
        }
        
        return sum;
    }
}