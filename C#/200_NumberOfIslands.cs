public class Solution {
    public int NumIslands(char[][] grid) {
        // Navigate on the land..
        // Keep last grid position..
        // Keep island count..
        
        int iCount = 0; // Amount of islands.
        
        HashSet<string> visited = new HashSet<string>();
        int[][] visited2 = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++) {
            visited2[i] = new int[grid[i].Length];
        }
            
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1' &&  visited2[i][j] != 1) {
                    visited2 = Navigate(i,j,grid, visited2); // Navigate!
                    iCount++;
                }
                else 
                    visited2[i][j] = 1;
            }
        }
        
        return iCount;
    }
    
    public int[][] Navigate(int i, int j, char[][] grid, int[][] visited) {
        Queue<List<int>> toVisit = new Queue<List<int>>();
        
        visited[i][j] = 1;
        toVisit.Enqueue(new List<int>(){i,j});
        
        while(toVisit.Count > 0) {
            List<int> visiting = toVisit.Dequeue();
             
            // Check left..
            if (visiting[1] > 0) {
                // If there is grid..
                if (grid[visiting[0]][visiting[1]-1] == '1') {
                    // If there is land..
                    if(visited[visiting[0]][visiting[1]-1] == 0) {
                        // If not visited
                        visited[visiting[0]][visiting[1]-1] = 1;
                        toVisit.Enqueue( new List<int>(){visiting[0], visiting[1]-1});
                    }
                }         
            }
            
            // Check right..
            if (visiting[1] < grid[visiting[0]].Length - 1) {
                // If there is grid..
                if (grid[visiting[0]][visiting[1]+1] == '1') {
                    // If there is land..
                     if(visited[visiting[0]][visiting[1]+1] == 0) {
                        // If not visited
                        visited[visiting[0]][visiting[1]+1] = 1;
                        toVisit.Enqueue( new List<int>(){visiting[0], visiting[1]+1});
                    }
                }   
            }
            
            
            // Check bottom..
            if (visiting[0] < grid.Length - 1) {
                // If there is grid..
                if (grid[visiting[0] + 1][visiting[1]] == '1') {
                    // If there is land..
                     if(visited[visiting[0] + 1][visiting[1]] == 0) {
                        // If not visited
                        visited[visiting[0] + 1][visiting[1]] = 1;
                        toVisit.Enqueue( new List<int>(){visiting[0] + 1, visiting[1]});
                    }
                }   
            }
            
            // Check top..
            if (visiting[0] > 0) {
                // If there is grid..
                if (grid[visiting[0] - 1][visiting[1]] == '1') {
                    // If there is land..
                    if(visited[visiting[0] - 1][visiting[1]] == 0) {
                        // If not visited
                        visited[visiting[0] - 1][visiting[1]] = 1;
                        toVisit.Enqueue( new List<int>(){visiting[0] - 1, visiting[1]});
                    }
                }   
            }
        }
        return visited;
    }
}
