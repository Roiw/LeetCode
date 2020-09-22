/*

    Idea: 
        - Traverse the matrix.
        - If element not water or used. BFS starting on element.
        - On BFS end, islands++.

*/

public class Solution {
    private void BFS(char[][] grid, int pX, int pY) {
        
        List<(int x, int y)> directions = new List<(int, int)>() { (1, 0), (-1, 0), (0, -1), (0, 1) };
        
        Queue<(int, int)> toVisit = new Queue<(int, int)>();
        toVisit.Enqueue((pX, pY));
        grid[pX][pY] = 'v';
        
        while (toVisit.Count > 0) {
            (int xV, int yV) = toVisit.Dequeue();
            
            foreach (var d in directions) {
                int x = xV + d.x;
                int y = yV + d.y;

                if (x >= 0 && x < grid.Length && y >= 0 && y < grid[x].Length && grid[x][y] == '1') {
                    toVisit.Enqueue((x, y));
                    grid[x][y] = 'v'; // mark as visited.
                }
            }
        }
        
    }
    public int NumIslands(char[][] grid) {
        int count = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1') {
                    count++;
                    BFS(grid, i, j);
                }
            }
        }
        
        return count;
    }
}