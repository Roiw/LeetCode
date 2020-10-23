public class Solution {
    
    private List<(int,int)> pos = new List<(int,int)> { (0, 1), (0, -1), (1, 0), (-1, 0) }; 

    
    public int MaxDistance(int[][] grid) {

        Queue<(int,int,int)> lands = new Queue<(int,int,int)>();
        
        // Mark lands with 0's and waters with very big number.
        for(int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    grid[i][j] = 0;
                    lands.Enqueue((i,j,1));
                }
                else {
                    grid[i][j] = Int32.MaxValue;
                }
            }
        } 
        
        if (lands.Count == 0 || lands.Count == grid.Length * grid.Length) return -1;
        
        // BFS from each land, saving minimum distances.
        while (lands.Count > 0) {
            (int lx, int ly, int d) = lands.Dequeue();
            foreach ( (int px, int py) in pos) {
                int x = px + lx;
                int y = py + ly;
                
                if (x >= 0 && x < grid.Length && y >= 0 && y < grid[x].Length) {
                    
                    if (grid[x][y] > d) {
                        grid[x][y] = d;
                        lands.Enqueue((x, y, d + 1)); // Add neighbors that could be improved.
                    }
                }   
            }
        }
        
        int maxDistance = -1;
        
        // Mark lands with 0's and waters with very big number.
        for(int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
               maxDistance = Math.Max(maxDistance, grid[i][j]);
            }
        } 
        
        
        return maxDistance;
    }
}
