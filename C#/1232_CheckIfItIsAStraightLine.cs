public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        
        float a = coordinates[1][0] - coordinates[0][0];
        float o = coordinates[1][1] - coordinates[0][1];
        float d = o/a;
        
        for (int i = 2; i < coordinates.Length - 1; i++){
            a = coordinates[i + 1][0] - coordinates[i][0];
            o = coordinates[i + 1][1] - coordinates[i][1];
            if (d != (o/a))
                return false;
        }
        return true;
    }
}
