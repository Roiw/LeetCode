public class Solution {
    // 06
    public int ArrangeCoins(int n) {
        int count = 0, i = 1;
        while (n > 0) {
            n -= i;
            if (n < 0) break;
            count++;
            i++;
        }
        return count;
    }
}
