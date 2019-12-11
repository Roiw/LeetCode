public class Solution {
    public bool JudgeCircle(string moves) {
        int verticalAxis = 0;
        int horizontalAxis = 0;
        
        foreach (char c in moves) {
            if (c.Equals('U')) {
                verticalAxis++;
            } else if (c.Equals('D')) {
                verticalAxis--;
            } else if (c.Equals('L')) {
                horizontalAxis++;
            } else if (c.Equals('R')) {
                horizontalAxis--;
            }
        }
        
        if (verticalAxis == 0 && horizontalAxis == 0) 
            return true;
        else
            return false;
    }
}
