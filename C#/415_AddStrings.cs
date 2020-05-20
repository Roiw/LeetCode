public class Solution {
    public string AddStrings(string num1, string num2) {
        
        string ans = "";
        int carry = 0;   
        
        int it = num1.Length > num2.Length? num1.Length : num2.Length;
        
        for (int i = 0; i < it; i++){
            int a = i < num1.Length ? (int)num1[num1.Length-1-i] - 48 : 0;
            int b = i < num2.Length ? (int)num2[num2.Length-1-i] - 48: 0;
            
            int r = (a + b + carry);
            carry = r > 9 ? 1 : 0;
            r = carry > 0? r - 10 : r;
            ans = (char)(r + 48) + ans;
        }
        
        return carry > 0 ? "1"+ans: ans;
    }
}
