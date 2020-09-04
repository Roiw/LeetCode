// 59
public class Solution {
    
    private enum Direction { Right, Left, Up, Down}
    
    public IList<int> SpiralOrder(int[][] matrix) {
        
        /* Graph solution! 
         1 - Go right whenever you can.
         2 - Go bottom until you cant anymore.
         3 - Go left until you cant anymore.
         4 - Go up until you can't.
         // Pay attention there is a twist when going up!
         */
        
        HashSet<(int,int)> visited = new HashSet<(int,int)>();
        List<int> ans = new List<int>();
        if (!(matrix.Length > 0 && matrix[0].Length > 0))
            return ans;
        
        int x = 0, y = 0; // starting position
        
        // Add first element
        ans.Add(matrix[x][y]);
        
        Direction currentDirection = Direction.Right;
        int end = matrix.Length * matrix[0].Length;
        int spiral = 0;
        while (ans.Count < end) {
            
            // Move right
            if (currentDirection == Direction.Right) {
                if( y <  matrix[x].Length - 1 - spiral)
                    y++;
                else
                    currentDirection = Direction.Down;
            }       
            
            // Move bottom
            if (currentDirection == Direction.Down) {
                if( x < matrix.Length - 1 - spiral)
                    x++;
                else
                    currentDirection = Direction.Left;
            }
            
            // Move left
            if (currentDirection == Direction.Left) {
                if( y > spiral)
                    y--;
                else
                    currentDirection = Direction.Up;
            }
            
            // Move upwards
            if (currentDirection == Direction.Up) {
                if( x > spiral + 1)
                    x--;
                else{
                    currentDirection = Direction.Right;
                    y++;
                    spiral++;
                }            
            }
            
            ans.Add(matrix[x][y]);
        }
        return ans;
    }
}