public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n < 1) return false;
        decimal r = (decimal)Math.Log((double) n, 2);
        return r == Math.Floor(r) ? true: false;
    }
}
