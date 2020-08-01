public class Solution {
    private int[] _mem;
    private int Climb(int n) {
        if (n == 1) return 1;
        if (_mem[n-1] != 0 ) return _mem[n-1];
        
        int pathWithOne = Climb(n - 1);
        int pathWithTwo = n > 2? Climb(n - 2): 0;
        pathWithTwo = n == 2? 1 : pathWithTwo;
        
        _mem[n-1] = (pathWithOne + pathWithTwo);
        return _mem[n-1];
    }
    public int ClimbStairs(int n) {
        _mem = new int[n];
        return Climb(n);
    }
}
