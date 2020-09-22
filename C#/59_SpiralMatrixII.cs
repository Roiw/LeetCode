/*
    
    Run on row, then column, then row.
    
    Approach 1 - Think in terms of Direction and Length.
    Approach 2 - Traverse the matrix in a weird way.
    
    
    Apporach 1
        direction = (1, 0) space = 3   | Full legnth
        direction = (0, -1) space = 2  | length -1
        direction = (-1, 0) space = 2  | length -1
        direction = (0, 1) space = 1   | length -2
        direction = (1, 0) space = 1   | length -2
    
*/

public class Solution {
    public (int x, int y) ChangeDirection ( int x, int y ) {
        if (x == 0 && y == 1) return  (1, 0);
        if (x == 1 && y == 0) return ( 0, -1);
        if (x == 0 && y == -1) return ( -1,  0);
        else return  ( 0,  1);
    }
    public int[][] GenerateMatrix(int n) {
        
        // Initialization
        int[][] ans = new int[n][];
        for(int i = 0; i < n; i++) { ans[i] = new int[n]; }
        
        int spaces = n, movements = 1, reps = 0;
        int a = 0, b = 0;
        var direction = (0, 1);
        for (int i = 1; i <= (n*n); i++){
            ans[a][b] = i;
            spaces--;
            
            // Change direction.
            if ( spaces == 0) {
                direction = ChangeDirection(direction.Item1, direction.Item2);
                movements++;
                if (movements == 2) { 
                    movements = 0;
                    reps++;
                }
                spaces  = n - reps;
            }
            
            (int x, int y) = direction;
            a += x; b += y;
        }
        
        return ans;
    }
}
