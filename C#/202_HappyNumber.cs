public class Solution {
    public bool IsHappy(int n) {
        
        int w = n;
        HashSet<int> cycle = new HashSet<int>();
        while (true) {
            string s = w.ToString();
            int sum = 0;
            foreach (char c in s){
                sum += (int)Math.Pow(Int32.Parse(c.ToString()), 2);
            }
            
            if (sum == 1) return true;
            if (!cycle.Add(sum)) return false;
            w = sum;
        }
        
    }
}
