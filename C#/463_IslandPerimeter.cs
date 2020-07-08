public class Solution {
    public int IslandPerimeter(int[][] grid) {
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) return DFS(grid, i, j);
            }
        }
        return 0;
    }
    private int DFS(int[][] grid, int x, int y) {
        if (grid[x][y] == -1) return 0;
        if (grid[x][y] == 0) return 1;
        
        grid[x][y] = -1;
        int perimeter = 0;
        
        // Check top
        perimeter += x > 0 ? DFS(grid, x - 1 , y): 1;
        // Check bottom
        perimeter += x < grid.Length -1 ? DFS(grid, x + 1 , y): 1;
        // Check left
        perimeter += y > 0 ? DFS(grid, x , y - 1): 1;
        // Check right
        perimeter += y < grid[x].Length - 1 ? DFS(grid, x , y + 1) : 1;
        
        return perimeter;
    }
}
