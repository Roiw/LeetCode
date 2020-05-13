public class Solution {
    public string RemoveKdigits(string num, int k) {        
        if (num.Length <= k) return "0";
        
        // Remove the first k elements..
        if (num[k] == 0)
            return num.Substring(k); 
        else {
            // Here I want to pick the smaller elements, as they come, considering that I have to select 
            // a number N of elements at the end. That's why we block some positions of the string. 
            int blocked = num.Length-k;
            int start = 0;
            string ans = "";
           while (blocked > 0) {
               (char c, int i) = FetchNumber(num, start, blocked);
               ans += c;
               start = i + 1;
               blocked--;
           }
            return RemoveZeroes(ans);
        }       
    }
    
    // Fetch the minimum number considering blocked positions..
    private (char, int) FetchNumber(string num, int start, int blocked){
        char min = 'a';
        int index = -1;
        for (int i  = start; i <= num.Length - blocked; i++){
            if (num[i] < min){
                min = num[i];
                index = i;
            }
        }
        return (min, index);
    }
    
    // Clear 0s left of numbers..
    private string RemoveZeroes (string s){
        if (s[0] != '0') return s;
        for (int i = 0; i < s.Length; i++){
            if (s[i] == '0'){
                s= s.Remove(i,1); i--;
            }
            else 
                return s.Length == 0? "0": s;
        }
        return s.Length == 0? "0": s;
    }
}
