/*
    - Take a look at Manacher's Algorithmn O(n)   
    
    The Plan:
    
        - Input is less than 1000. I can certainly go with O(N2) solution.
        - Start at each character of the string, we grow a palindrome to the sides.
        - Keep track of the biggest palindrome that was grown.    
*/

public class Solution {
    
    int longest_P0;
    int longest_P1;
    
    private void CheckIncrease(int p0, int p1) {
        if (p1 - p0 > longest_P1 - longest_P0) {
            longest_P1 = p1;
            longest_P0 = p0;
        }
    }
    ac
    // Palindrome could be centered on center (odd) or could be a even palindrome.
    private void GrowPalindrome(string s, int center, bool odd) {
        int p0 = center, p1 = odd? center : center + 1;
        
        while (p0 >= 0 && p1 < s.Length) {
            if (s[p0] == s[p1]) {
                CheckIncrease(p0,p1);
            }
            else {
                break;
            }
            p0--;
            p1++;
        }
    }
    
    
    public string LongestPalindrome(string s) {    
        longest_P0 = 0;
        longest_P1 = -1;

        
        for(int i = 0; i < s.Length; i++) {
            GrowPalindrome(s, i, true);
            GrowPalindrome(s, i, false);
        }
        
        return longest_P0 < 0? "" : s.Substring(longest_P0, longest_P1 - longest_P0 + 1) ;
    }
}
