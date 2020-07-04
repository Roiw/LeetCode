public class Solution {
    public int NthUglyNumber(int n) {
        if (n <= 0) return 0;
        List<int> uglies = new List<int>(){1};
        int i2 = 0, i3 = 0, i5 = 0; 
        
        while (uglies.Count < n) {
            int a = uglies[i2] * 2;
            int b = uglies[i3] * 3;
            int c = uglies[i5] * 5;
            
            int nextUgly = Math.Min(a, Math.Min(b,c));
            
            i2 = nextUgly == a? i2 + 1 : i2;
            i3 = nextUgly == b? i3 + 1 : i3;
            i5 = nextUgly == c? i5 + 1 : i5;
            
            uglies.Add(nextUgly);
        }
        return uglies[n-1];
    }
}
