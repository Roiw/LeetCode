public class Solution {
    public double AngleClock(int hour, int minutes) {
        double dMin = (double) minutes;
        double dHour = (double)hour * 5 + dMin*5/60;
        double d1 = Math.Abs(dHour-dMin);
        double d2 = Math.Abs(60-d1);
        double minDistance = Math.Min(d1, d2); 
        return minDistance * 6;
    }
}
