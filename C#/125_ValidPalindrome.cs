public class Solution {
    public bool IsPalindrome(string s) {
        if (s == "")
            return true;
        
        int j = s.Length - 1;
        int i = 0;
        bool gotA = false;
        bool gotB = false;
        char a = ' ', b = ' ';
        while(true) {
            
            if (!gotA) {
                if (s[i] >= 'A' && s[i] <= 'Z' ) {
                   a = (char)(s[i] + 32);
                   gotA = true;
                }                
                else if (s[i] >= 'a' && s[i] <= 'z') {
                    a = s[i];
                    gotA = true;
                }
                else if (s[i] >= '0' && s[i] <= '9'){
                    a = s[i];
                    gotA = true;
                }
                i++;
            }
               
            if (!gotB) {
                if (s[j] >= 'A' && s[j] <= 'Z' ){   
                    b = (char)(s[j] + 32); 
                    gotB = true; 
                }
                else if (s[j] >= 'a' && s[j] <= 'z'){
                    b = s[j]; 
                    gotB = true; 
                }
                else if (s[j] >= '0' && s[j] <= '9'){
                    b = s[j]; 
                    gotB = true; 
                }
                j--;
            }
            
            
            if (gotA && gotB && a != b) 
                return false;
            else if (gotA && gotB && a == b){
                gotA = false; 
                gotB = false; 
            }
            
            if (i > j)
                break;
                
        }
        
        return true;
    }
}
