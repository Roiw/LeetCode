
/*
    According to the tips. O(N) 
    It stays in a cycle if at the end of one set of instructions:
        It doesnt end with the same direction as start.
            Or 
        If it is not on the same start position
    
*/

public class Solution {
    public bool IsRobotBounded(string instructions) {
        
        int dir = 0;
        int x = 0, y = 0;
        foreach (char c in instructions){
            if ( c == 'R' )
                dir += dir < 3? 1 : -3;
            else if ( c == 'L' )
                dir -= dir > 0? 1 : -3;
            else {
                if (dir == 0)
                    y ++;
                if (dir == 1)
                    x ++;
                if (dir == 2)
                    y --;
                if (dir == 3)
                    x --;
            }
        }
        
        return dir != 0 || ( x == 0 && y == 0);    
    }
}
