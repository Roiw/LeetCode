public class Solution {
    public bool IsMonotonic(int[] A) {
        bool decreasing = true;
        bool increasing = true;
        int last = A[0];
        foreach (int i in A){
            if (last > i && increasing)
                increasing = false;
            if (last < i && decreasing)
                decreasing = false;
            last = i;
            if (!increasing && !decreasing) return false;
        }
        return increasing || decreasing;
    }
}
