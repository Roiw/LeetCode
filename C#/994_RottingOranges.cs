public class Solution {
    public int OrangesRotting(int[][] grid) {
        // Identify (X, Y) for each rotten orange.
        // If none retun -1.
        // For each rottenOranges, add all neighbours that were good oranges to rottenOranges.
        // Increment the minute count (+1)
        // For every new rotten apple we subtract from the number of good apples left. 
        // If we reached 0  return the amount of minutes.
        
        // Idenfying rotten oranges..
        HashSet<(int,int)> visited = new HashSet<(int,int)>();
        Queue<(int,int,int)> rottenOranges = new Queue<(int,int,int)>(); 
        int goodOranges = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 2){
                    visited.Add((i, j));
                    rottenOranges.Enqueue((i, j, 0));
                }
                if (grid[i][j] == 1)
                    goodOranges++;
            }
        }
        if (goodOranges == 0) return 0;
        if (rottenOranges.Count == 0) return -1;
            
        // Start moving time and checking oranges..
        while (rottenOranges.Count > 0) {
            (int i, int j, int time) = rottenOranges.Dequeue();
            // Check left
            if (j > 0 && grid[i][j-1] == 1 && visited.Add((i, j - 1))) {
                rottenOranges.Enqueue((i, j - 1, time + 1));
                goodOranges--;
            }          
            // Check right
            if (j < grid[i].Length - 1 && grid[i][j + 1] == 1 && visited.Add((i , j + 1))) {
                rottenOranges.Enqueue((i, j + 1, time + 1));
                goodOranges--;
            }
            
            // Check up
            if (i > 0 && grid[i - 1][j] == 1 && visited.Add((i - 1, j))) {
                rottenOranges.Enqueue((i -1, j, time + 1));
                goodOranges--;
            }
                
            // Check bottom
            if (i < grid.Length - 1 && grid[i + 1][j] == 1 && visited.Add((i + 1, j))) {
                rottenOranges.Enqueue((i + 1, j, time + 1));
                goodOranges--;
            }          
            if (goodOranges == 0) return time + 1;
        }
        return -1;
    }
}
