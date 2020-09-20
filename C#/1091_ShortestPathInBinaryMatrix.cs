/*

    02
    
    The length of the shortest path (BFS Approach):
        - Start BFS from top left, once it reaches the bottom we have the minimum path

*/
public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if (grid[0][0] == 1) return -1; // Edge case
        int answer = -1;
        List<(int x, int y)> cells = new List<(int, int)>() { (0, 1), (0, -1), (-1, 0), (1, 0), (1, 1), (-1, 1), (-1, -1), (1, -1 ) };
        Queue<(int x, int y, int distance)> toExplore = new Queue<(int, int, int)>();
        toExplore.Enqueue((0, 0, 1));
        while ( toExplore.Count > 0) {
            (int x, int y, int distance) = toExplore.Dequeue();
            
            if (x == grid.Length - 1 && y == grid.Length - 1)
                return distance;
            
            foreach (var cell in cells) {
                int newX = cell.x + x;
                int newY = cell.y + y;
                if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[x].Length && grid[newX][newY] == 0){
                    toExplore.Enqueue((newX, newY, distance + 1));
                    grid[newX][newY] = 1;
                }          
            }
        }
        return -1;
    }
}
