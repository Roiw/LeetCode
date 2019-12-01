public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for (int divisor = 1; divisor < s.Length; divisor++) {
            
            // Check if this divisor works.. 
            if (s.Length % divisor != 0)
            continue;
            
            // Check if this divisor has substring that forms S.
            if (!Check(s, divisor))
                continue;
            else 
                return true;
        }
        return false;
    }
    
    public bool Check(string s, int divisor) {
         // Substring for this divisor..
         string sub = s.Substring(0, divisor);
            
         // Testing..
         string tst = s.Substring(divisor, divisor);
        
 
         for (int i = 1; i < s.Length / divisor; i++) {
             
             tst = s.Substring(divisor * i, divisor);
             if (!sub.Equals(tst)) {
                 return false;
             }
          }
          return true;
     }
}
