public class Solution {
    public int MinSize = int.MaxValue;
    public int rSize = 0;
    public int cSize = 0;
    public int[][] helperGrid;
    public int MinPathSum(int[][] grid) {
        
        helperGrid = new int[grid.Length][];
        
        rSize = grid.Length-1;
        cSize = grid[rSize].Length-1;
        
        for (int i = 0; i < rSize+1; i++){
            helperGrid[i] = new int[grid[i].Length];
        }    
        
        return Explore(grid,0,0);
    }
    public int Explore(int[][] grid, int i, int j){
        
        // Base case we are at the end..
        if (rSize == i && cSize == j){
            return grid[i][j];
        }
        
        int a = int.MaxValue, b = int.MaxValue;
        
        if (i < rSize) {
            a = helperGrid[i+1][j] == 0 ? Explore(grid,i + 1,j) : helperGrid[i+1][j];
        }
        if (j < cSize){
            b = helperGrid[i][j+1] == 0 ? Explore(grid,i,j + 1) : helperGrid[i][j + 1];
        }
       
        helperGrid[i][j] = a > b ? b : a;
        helperGrid[i][j] += grid[i][j];
        
        return helperGrid[i][j];
    }
}
