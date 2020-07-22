public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        int aux = x, reversed = 0;
        while ( aux > 0 ) {
            int increment = aux % 10;
            reversed = reversed * 10 + increment;
            aux = aux / 10;
        }
        if (reversed == x) return true;
        return false;
    }
}
