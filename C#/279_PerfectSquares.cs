public class Solution {
    Dictionary<int,int> _dp = new Dictionary<int,int>(); // Top-Down DP.
    public int NumSquares(int n) {
        if (n < 4) return n;
        double d = Math.Sqrt(n);
        int pps = (int) Math.Floor(d); // Previous Perfect Square
        if(d == pps) return 1;
        
        int count = n;
        
        for(int i = pps; i > 0; i--) {
            int next = n - i * i;
            if (!_dp.ContainsKey(next)) {
                _dp.Add(next, NumSquares(next));
            }
            
            count = Math.Min(_dp[next] + 1, count);
        }
        return count;
    }
}
