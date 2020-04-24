public class Solution {
    public int RangeBitwiseAnd(int m, int n) {     
        int a = n-m;
        int i = (int)Math.Ceiling(Math.Log(a, 2));
        
        if (i >= 1) {
            int k = 2147483647 << i;  
            n = n & k;
        }
        
        return n & m;
    }
}
