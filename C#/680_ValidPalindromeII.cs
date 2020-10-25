
public class Solution {
    public bool ValidPalindrome(string s) {
        int p0 = 0, p1 = s.Length - 1;
        
        while (p0 < p1) {
            if (s[p0] != s[p1])
                return IsPalindrome(s.Remove(p0,1)) || IsPalindrome(s.Remove(p1,1));
            p0++;
            p1--;
        }
        return true;
    }
    
    private bool IsPalindrome(string s) {
        int p0 = 0, p1 = s.Length - 1;
        
        while (p0 < p1) {
            if (s[p0] != s[p1])
                return false;
            
            p0 ++;
            p1 --;
        }
        return true;
    }
}
