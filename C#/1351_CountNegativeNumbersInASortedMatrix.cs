public class Solution {
    public int CountNegatives(int[][] grid) {
        int negatives = 0;
        for (int i = 0; i < grid.Length; i++){
            for (int j = 0; j < grid[i].Length; j++){
                negatives = grid[i][j] < 0? negatives + 1: negatives;
            }
        }
        return negatives;
    }
}
