public class Solution {
    private double binSearch(int target, double min, double max)
    {
        if (min > max)
            return max;
        double mid = Math.Floor(min + (max-min)/2);
        if ((mid * mid) == (double)target)
            return mid;
        if ((mid * mid) < target)
            return binSearch(target, mid + 1, max);
        else
            return binSearch(target, min, mid - 1);
    }
    public int MySqrt(int x) {
        // 10
        if (x == 1) return 1;
        return (int)binSearch(x, 0, x/2);
    }
}
