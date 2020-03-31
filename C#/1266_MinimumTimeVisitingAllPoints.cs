public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int x = points[0][0], y = points[0][1], t = 0;        
        for (int i = 1; i < points.Length; i++) {
            int d1 = Math.Abs(points[i][0] - x);
            int d2 = Math.Abs(points[i][1] - y);
            t += Math.Abs(d1 - d2);
            t = d1 > d2 ? d2 + t: d1 + t;
            x = points[i][0]; y = points[i][1];
        }   
        return t;
    }
}
